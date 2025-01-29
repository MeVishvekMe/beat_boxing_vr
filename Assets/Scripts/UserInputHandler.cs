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
        DontDestroyOnLoad(gameObject);

        xriDefaultInputActions = new XRIDefaultInputActions();
    }

    private void OnEnable() {
        xriDefaultInputActions.Enable();
        xriDefaultInputActions.XRIRight.AButton.performed += AButtonOnPerformed;
        xriDefaultInputActions.XRIRight.BButton.performed += BButtonOnPerformed;
    }

    private void OnDisable() {
        xriDefaultInputActions.XRIRight.AButton.performed -= AButtonOnPerformed;
        xriDefaultInputActions.XRIRight.BButton.performed -= BButtonOnPerformed;
        xriDefaultInputActions.Disable();
    }

    private void AButtonOnPerformed(InputAction.CallbackContext obj) {
        pauseButtonEvent?.Invoke(this, EventArgs.Empty);
    }

    private void BButtonOnPerformed(InputAction.CallbackContext obj) {
        resumeButtonEvent?.Invoke(this, EventArgs.Empty);
    }
    
}