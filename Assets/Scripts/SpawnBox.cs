using System;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SpawnBox : MonoBehaviour {
    // GameObject holding all the song's timestamps
    public GameObject songTimeStampGameObject;
    
    // Array of the TimeStampDS
    private TimeStampDS[] timeStampDS;
    
    // GameManagerScript object for updating scoreText
    private ScoreManager scoreManager;

    // AudioPlayer of the song
    public AudioSource songAudioSource;
    
    // Variable for iterating the TimeStamps
    private int _currentStamp = 0;
    private bool stopPlaying = false;

    [SerializeField] private GameEndingHandler gameEndingHandler;

    private void Start() {
        // Initialization of the variables
        scoreManager = GetComponent<ScoreManager>();
        // timeStampDS = songTimeStampGameObject.GetComponent<DemoSongTimeStamps>().ReturnTimeStampArray();
        timeStampDS = LevelSelectorHelper.songs[LevelSelectorHelper.selectedSongIndex].ReturnTimeStampArray();
        Debug.Log(timeStampDS[_currentStamp].timeStamp);
        UserInputHandler.Instance.pauseButtonEvent += PauseAudioPlayer;
        UserInputHandler.Instance.resumeButtonEvent += ResumeAudioPlayer;
    }
    
    private void OnDestroy() {
        if (UserInputHandler.Instance != null) { 
            UserInputHandler.Instance.pauseButtonEvent -= PauseAudioPlayer;
            UserInputHandler.Instance.resumeButtonEvent -= ResumeAudioPlayer;
        }
    }


    private void PauseAudioPlayer(object sender, EventArgs e) {
        if (stopPlaying || songAudioSource == null) return;
        songAudioSource.Pause();
        stopPlaying = true;
    }

    private void ResumeAudioPlayer(object sender, EventArgs e) {
        if (!stopPlaying || songAudioSource == null) return;
        songAudioSource.Play();
        stopPlaying = false;
    }


    private void Update() {
        if (!stopPlaying && songAudioSource.time >= timeStampDS[_currentStamp].timeStamp - 2f) {
            InsBox(timeStampDS[_currentStamp]);
            _currentStamp++;
            if (_currentStamp == timeStampDS.Length) {
                Debug.Log("Limit");
                stopPlaying = true;
                gameEndingHandler.EndScreen();
            }
        }
    }

    private void InsBox(TimeStampDS timeStamp) {
        GameObject gb = Instantiate(timeStamp.spawnType, timeStamp.spawnPoint.position, Quaternion.identity);
    }

    private void ChangeScene() {
        SceneManager.LoadScene(0);
    }
}