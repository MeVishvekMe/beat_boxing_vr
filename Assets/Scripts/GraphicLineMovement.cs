using UnityEngine;

public class GraphicLineMovement : MonoBehaviour {
    public float movementSpeed = 200f;

    void Update() {
        transform.localPosition -= new Vector3(0, 0, movementSpeed * Time.deltaTime);
    }
}
