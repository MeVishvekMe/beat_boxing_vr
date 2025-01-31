using System;
using UnityEngine;
using UnityEngine.InputSystem;

public class GameStateHandler : MonoBehaviour {
    public static void GamePause() {
        UserInputHandler.Instance.PauseEventFire();
    }
    
    public static void GameResume() {
        
        UserInputHandler.Instance.ResumeEventFire();
    }
}
