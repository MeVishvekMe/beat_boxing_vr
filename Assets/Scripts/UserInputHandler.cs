using System;
using UnityEngine;
using UnityEngine.InputSystem;

public class UserInputHandler : MonoBehaviour {
    public XRIDefaultInputActions xriDefaultInputActions;

    private void Awake() {
        xriDefaultInputActions = new XRIDefaultInputActions();
    }

    private void Start() {
        xriDefaultInputActions.XRIRight.AButton.performed += AButtonOnperformed;
    }

    private void AButtonOnperformed(InputAction.CallbackContext obj) {
        throw new NotImplementedException();
    }
}
