using System;
using UnityEngine;

public class GloveScript : MonoBehaviour {
    private void OnCollisionEnter(Collision other) {
        
    }

    private void OnTriggerEnter(Collider other) {
        Debug.Log(other.gameObject.name);
        if (other.CompareTag("CubeShatter")) {
            Debug.Log("Collision with cube");
            other.gameObject.GetComponent<ShatterExplosion>().Explode();
        }
    }
}
