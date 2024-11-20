using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit.Inputs.Haptics;

public class GloveScript : MonoBehaviour {
    public HapticImpulsePlayer controller;
    
    public GameManagerScript gameManager;

    private void OnTriggerEnter(Collider other) {
        if (other.CompareTag("CubeShatter")) {  
            SendHapticFeedback();
            gameManager.IncreaseScore();
            other.gameObject.GetComponent<BoxCollider>().enabled = false;
            other.gameObject.GetComponent<BoxMovement>().enabled = false;
            other.gameObject.GetComponent<ShatterExplosion>().Explode();
        }
    }

    private void SendHapticFeedback() {
        controller.SendHapticImpulse(0.5f, 0.2f);
    }
}
