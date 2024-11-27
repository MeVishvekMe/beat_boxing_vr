using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour {
    public void ChangeToGameScene() {
        SceneManager.LoadScene("GameScene");
    }

    public void ChangeToMenuScene() {
        SceneManager.LoadScene("MenuScene");
    }
}
