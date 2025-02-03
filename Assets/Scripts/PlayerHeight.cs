using UnityEngine;

public class PlayerHeight : MonoBehaviour {
    public static float PlayerHeightValue = 1.7f;

    public GameObject playButton;
    public GameObject exitButton;
    public GameObject setButton;

    private void Update() {
        Debug.Log("PlayerHeightValue = " + PlayerHeightValue);
        Debug.Log("Current Height = " + (Camera.main.transform.position.y));
    }

    public void SetPlayerHeight() {
        PlayerHeightValue = Camera.main.transform.position.y;
        playButton.SetActive(true);
        exitButton.SetActive(true);
        setButton.SetActive(false);
    }
}
