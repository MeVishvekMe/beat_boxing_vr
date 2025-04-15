using System;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseManager : MonoBehaviour {
    public GameObject leftControllerUI;
    public GameObject leftControllerGameplay;
    public GameObject rightControllerUI;
    public GameObject rightControllerGameplay;
    public GameObject leftGlove;
    public GameObject rightGlove;
    public GameObject pauseUI;
    
    public static PauseManager Instance;

    private void Awake() {
        if (Instance != null && Instance != this) {
            Destroy(gameObject);
            return;
        }
        Instance = this;
        //DontDestroyOnLoad(gameObject);
    }
    
    public void PauseDisableObjects() {
        leftGlove.SetActive(false);
        leftControllerGameplay.SetActive(false);
        rightGlove.SetActive(false);
        rightControllerGameplay.SetActive(false);
        
        leftControllerUI.SetActive(true);
        rightControllerUI.SetActive(true);
        pauseUI.SetActive(true);
    }

    public void ResumeDisableObjects() {
        leftGlove.SetActive(true);
        leftControllerGameplay.SetActive(true);
        rightGlove.SetActive(true);
        rightControllerGameplay.SetActive(true);
        
        leftControllerUI.SetActive(false);
        rightControllerUI.SetActive(false);
        pauseUI.SetActive(false);
    }

    public void GoBack() {
        SceneManager.LoadScene(0);
    }
}
