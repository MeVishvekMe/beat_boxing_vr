using UnityEngine;

public class DodgeObjectVisualEffects : MonoBehaviour {
    // Speed of rotation
    public float rotationSpeedMin = 10f; // Minimum rotation speed
    public float rotationSpeedMax = 50f; // Maximum rotation speed
    private Vector3 rotationAxis;

    void Start() {
        // Choose a random axis for rotation (x, y, or z)
        rotationAxis = new Vector3(Random.Range(-1f, 1f), Random.Range(-1f, 1f), Random.Range(-1f, 1f)).normalized;

        // Optionally, you can use a random speed within the defined range
        float rotationSpeed = Random.Range(rotationSpeedMin, rotationSpeedMax);
        rotationAxis *= rotationSpeed;
    }

    void Update() {
        // Rotate the object gradually on the chosen axis at the set speed
        transform.Rotate(rotationAxis * Time.deltaTime);
    }
}