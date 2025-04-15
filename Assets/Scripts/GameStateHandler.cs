using System;
using UnityEngine;

public class GameStateHandler : MonoBehaviour {
    
    public static void TutorialPause() {
        UserInputHandler.Instance.PauseEventFire(true);
    }
    
    public static void GamePause() {
        UserInputHandler.Instance.PauseEventFire(false);
    }
    
    public static void GameResume() {
        UserInputHandler.Instance.ResumeEventFire();
    }
}
