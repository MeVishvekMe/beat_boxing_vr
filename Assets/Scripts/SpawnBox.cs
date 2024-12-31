using UnityEngine;
using UnityEngine.SceneManagement;

public class SpawnBox : MonoBehaviour {
    // GameObject holding all the song's timestamps
    public GameObject songTimeStampGameObject;
    
    // Array of the TimeStampDS
    private TimeStampDS[] timeStampDS;
    
    // GameManagerScript object for updating scoreText
    private GameManagerScript gameManagerScript;

    // AudioPlayer of the song
    public AudioSource songAudioSource;
    
    // Variable for iterating the TimeStamps
    private int _currentStamp = 0;
    private bool stopPlaying = false;

    private void Start() {
        
        // Initialization of the variables
        gameManagerScript = GetComponent<GameManagerScript>();
        timeStampDS = songTimeStampGameObject.GetComponent<UnityTimeStamps>().ReturnTimeStampArray();
        
    }

    private void Update() {
        if (!stopPlaying && songAudioSource.time >= timeStampDS[_currentStamp].timeStamp - 2f) {
            InsBox(timeStampDS[_currentStamp]);
            _currentStamp++;
            if (_currentStamp == timeStampDS.Length) {
                stopPlaying = true;
                Invoke("ChangeScene", 2f);
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