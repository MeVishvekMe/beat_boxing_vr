using System;
using UnityEngine;

public class MissCalculatorScript : MonoBehaviour {
    
    public GameManagerScript gameManager;
    private void OnTriggerEnter(Collider other) {
        if (other.CompareTag("CubeShatter") || other.CompareTag("CubeDouble")) {
            gameManager.ResetMultiplier();
            Destroy(other.gameObject);
        }
    }
}
