using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;
using UnityEngine.UI;

public class MenuScript : MonoBehaviour {
    public GameObject calibrationScreen;
    public GameObject playAndExitScreen;
    public GameObject difficultyScreen;
    public Slider progressSlider;

    
    
    public void StartGameSceneLoading() {
        progressSlider.gameObject.SetActive(true);
        StartCoroutine(LoadSceneAsync(1)); // Replace '1' with your build index
    }

    public void SetPlayerHeight() {
        PlayerHeight.SetPlayerHeight();
        calibrationScreen.SetActive(false);
        playAndExitScreen.SetActive(true);
    }

    public void Play() {
        playAndExitScreen.SetActive(false);
        difficultyScreen.SetActive(true);
    }

    public void SelectLevel(int index) {
        LevelSelectorHelper.selectedSongIndex = index;
        difficultyScreen.SetActive(false);
        StartGameSceneLoading();
    }
    
    
    private IEnumerator LoadSceneAsync(int sceneIndex) {
        // Start loading the scene asynchronously
        AsyncOperation operation = SceneManager.LoadSceneAsync(sceneIndex);

        // Prevent the scene from switching automatically
        operation.allowSceneActivation = false;

        // While the scene is loading, update the slider
        while (!operation.isDone)
        {
            if (progressSlider != null)
            {
                // Update slider value (progress ranges from 0 to 0.9)
                progressSlider.value = Mathf.Clamp01(operation.progress / 0.9f);
            }

            // If the scene has finished loading (progress is 0.9), activate the scene
            if (operation.progress >= 0.9f)
            {
                // Wait for a brief moment or condition before activating the scene
                yield return new WaitForSeconds(0.5f);
                operation.allowSceneActivation = true;
            }

            yield return null;
        }
    }

    public void ExitGame() {
        // Display a log message in the Unity Editor (useful for debugging in Editor mode)
        Debug.Log("Exiting game...");

        Application.Quit();
    }

}
