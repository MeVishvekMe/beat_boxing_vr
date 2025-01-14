using System;
using UnityEngine;
using UnityEngine.Serialization;

public class MissCalculatorScript : MonoBehaviour {
    
    [FormerlySerializedAs("gameManager")] public ScoreManager scoreManager;
    private void OnTriggerEnter(Collider other) {
        if (other.CompareTag("CubeShatter") || other.CompareTag("CubeDouble")) {
            scoreManager.ResetMultiplier();
            Destroy(other.gameObject);
        }
    }
}
