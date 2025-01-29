using System;
using UnityEngine;
using System.Collections;

public class BoxMovement : MonoBehaviour {
    private Rigidbody _rb;

    private bool isPaused = false;

    private void Start() {
        _rb = GetComponent<Rigidbody>();
        UserInputHandler.Instance.pauseButtonEvent += StopBoxMovement;
        UserInputHandler.Instance.resumeButtonEvent += StartBoxMovement;
        StartBoxMovement(this, EventArgs.Empty);
    }

    private void StartBoxMovement(object sender, EventArgs e) {
        if (_rb == null) return;
        _rb.linearVelocity = new Vector3(0, 0, -6.75f);
    }

    private void StopBoxMovement(object sender, EventArgs e) {
        if (_rb == null) return;
        _rb.linearVelocity = new Vector3(0, 0, 0);
    }

    private void OnDestroy() {
        UserInputHandler.Instance.pauseButtonEvent -= StartBoxMovement;
        UserInputHandler.Instance.resumeButtonEvent -= StopBoxMovement;
    }
}