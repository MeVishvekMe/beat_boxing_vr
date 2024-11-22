using UnityEngine;

public class GraphicLineMovement : MonoBehaviour {
    private float _movementSpeed = 100f;

    void Update() {
        transform.localPosition -= new Vector3(0, 0, _movementSpeed * Time.deltaTime);
    }
}
