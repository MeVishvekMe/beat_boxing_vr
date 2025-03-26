using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameEndingHandler : MonoBehaviour {
    [SerializeField] private TextMeshProUGUI endingText;
    [SerializeField] private ScoreManager scoreManager;
    
    public void EndScreen() {
        endingText.text = "Congratulations\nYou have completed the demo level of BeatBoxing";
        endingText.gameObject.SetActive(true);
        Invoke("ChangeToLeaderboardScene", 10f);
    }

    public void ChangeToLeaderboardScene() {
        SceneManager.LoadScene(0);
    }
}
