using System;
using UnityEngine;

public class MissCalculatorScript : MonoBehaviour {
    
    public GameManagerScript gameManager;
    private void OnTriggerEnter(Collider other) {
        if (other.CompareTag("CubeShatter")) {
            gameManager.ResetMultiplier();
            Destroy(other.gameObject);
        }
    }
}
