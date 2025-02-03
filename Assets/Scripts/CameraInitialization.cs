using UnityEngine;

public class CameraInitialization : MonoBehaviour
{
    void Start() {
        transform.rotation = Quaternion.Euler(0, 0, 0); // Adjust based on ship's forward direction
    }

}
