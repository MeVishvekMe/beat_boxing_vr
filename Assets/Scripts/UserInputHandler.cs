using System;
using UnityEngine;
using UnityEngine.InputSystem;

public class UserInputHandler : MonoBehaviour {
    private XRIDefaultInputActions xriDefaultInputActions;

    public event EventHandler pauseButtonEvent;
    public event EventHandler resumeButtonEvent;

    public static UserInputHandler Instance;

    private void Awake() {
        if (Instance != null && Instance != this) {
            Destroy(gameObject);
            return;
        }
        Instance = this;
        //DontDestroyOnLoad(gameObject);

        xriDefaultInputActions = new XRIDefaultInputActions(); // Ensure it's initialized
    }

    private void OnEnable() {
        if (xriDefaultInputActions == null) {
            xriDefaultInputActions = new XRIDefaultInputActions(); // Reinitialize if null
        }

        xriDefaultInputActions.Enable();
        xriDefaultInputActions.XRIRight.AButton.performed += AButtonOnPerformed;
        xriDefaultInputActions.XRIRight.BButton.performed += BButtonOnPerformed;
    }

    private void OnDisable() {
        if (xriDefaultInputActions == null) return; // Prevent NullReferenceException

        xriDefaultInputActions.XRIRight.AButton.performed -= AButtonOnPerformed;
        xriDefaultInputActions.XRIRight.BButton.performed -= BButtonOnPerformed;
        xriDefaultInputActions.Disable();
    }

    private void AButtonOnPerformed(InputAction.CallbackContext obj) {
        PauseEventFire(false);
    }

    private void BButtonOnPerformed(InputAction.CallbackContext obj) {
        ResumeEventFire();
    }

    public void PauseEventFire(bool isTutorial) {
        pauseButtonEvent?.Invoke(this, EventArgs.Empty);
        if (!isTutorial) {
            PauseManager.Instance.PauseDisableObjects();
        }
    }

    public void ResumeEventFire() {
        resumeButtonEvent?.Invoke(this, EventArgs.Empty);
        PauseManager.Instance.ResumeDisableObjects();
    }
}