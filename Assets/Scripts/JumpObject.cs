using System;
using UnityEngine;

public class JumpObject : MonoBehaviour {

    private bool didJumped = false;

    private void OnTriggerStay(Collider other) {
        if (other.CompareTag("Player")) {
            if (Camera.main.transform.position.y >= PlayerHeight.PlayerHeightValue + 0.20f) {
                didJumped = true;
            }
        }
    }

    private void OnTriggerExit(Collider other) {
        if (other.CompareTag("Player") && !didJumped) {
            Camera.main.GetComponent<CameraHitBehaviour>().HitVisualStart();
        }
    }
}
