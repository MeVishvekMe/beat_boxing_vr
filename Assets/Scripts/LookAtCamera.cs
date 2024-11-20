using UnityEngine;

public class LookAtCamera : MonoBehaviour {
    void Update() {
        // Make the object look at the camera
        transform.LookAt(Camera.main.transform.position);

        // Apply a 180-degree rotation around the Y-axis
        transform.rotation *= Quaternion.Euler(0, 180f, 0);
    }
}