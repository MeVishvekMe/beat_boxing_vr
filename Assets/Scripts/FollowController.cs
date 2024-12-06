using System;
using UnityEngine;

public class FollowController : MonoBehaviour
{
    public GameObject controller; // The controller the gloves will follow
    private Rigidbody rb;

    private Vector3 previousPosition; // To track position changes
    private Vector3 calculatedVelocity; // To store calculated velocity
    private float speed; // To store the magnitude of the velocity

    private void Start() {
        rb = GetComponent<Rigidbody>();

        if (rb == null) {
            Debug.LogWarning("Rigidbody component not found. Velocity will be calculated manually.");
        }

        previousPosition = transform.position;
    }

    private void Update() {
        // Synchronize position and rotation with the controller
        transform.position = controller.transform.position;
        transform.rotation = controller.transform.rotation;

        // Calculate velocity manually
        calculatedVelocity = (transform.position - previousPosition) / Time.deltaTime;
        speed = calculatedVelocity.magnitude; // Store the magnitude of the velocity
        previousPosition = transform.position;
    }

    public float GetSpeed() {
        return speed;
    }
}