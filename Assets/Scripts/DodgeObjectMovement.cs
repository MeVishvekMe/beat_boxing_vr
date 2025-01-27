using System;
using UnityEngine;

public class DodgeObjectMovement : MonoBehaviour {
    private Rigidbody _rb;
    private Vector3 startingPosition;

    private void Start() {
        _rb = GetComponent<Rigidbody>();
        startingPosition = transform.position;
        _rb.linearVelocity = CalculateMovementSpeed();
    }

    private Vector3 CalculateMovementSpeed() {
        Vector3 cameraPosition = Camera.main.transform.position;
        float displacement = Vector3.Distance(cameraPosition, startingPosition);
        float speed = displacement / 2f;
        Debug.Log(speed);
        return (cameraPosition - startingPosition).normalized * speed;
    }
}
