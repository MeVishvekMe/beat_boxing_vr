using System;
using UnityEngine;

public class DodgeObjectMovement : MonoBehaviour {
    private Rigidbody _rb;
    private Vector3 startingPosition;

    private void Start() {
        _rb = GetComponent<Rigidbody>();
        startingPosition = transform.position;
        UserInputHandler.Instance.pauseButtonEvent += StopObjectMovement;
        UserInputHandler.Instance.resumeButtonEvent += StartObjectMovement;
        StartObjectMovement(this, EventArgs.Empty);
    }

    private void StartObjectMovement(object sender, EventArgs e) {
        if (_rb == null) return;
        _rb.linearVelocity = CalculateMovementSpeed();
    }

    private void StopObjectMovement(object sender, EventArgs e) {
        if (_rb == null) return;
        _rb.linearVelocity = Vector3.zero;
    }

    private void OnDestroy() {
        UserInputHandler.Instance.pauseButtonEvent -= StopObjectMovement;
        UserInputHandler.Instance.resumeButtonEvent -= StartObjectMovement;
    }

    private Vector3 CalculateMovementSpeed() {
        Vector3 cameraPosition = Camera.main.transform.position;
        float displacement = Vector3.Distance(cameraPosition, startingPosition);
        float speed = displacement / 2f;
        Debug.Log(speed);
        return (cameraPosition - startingPosition).normalized * speed;
    }
}
