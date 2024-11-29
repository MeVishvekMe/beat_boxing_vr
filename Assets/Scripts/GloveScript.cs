using System;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit.Inputs.Haptics;

public class GloveScript : MonoBehaviour {
    public HapticImpulsePlayer controller;
    
    public GameManagerScript gameManager;
    public AudioSource hitSoundAudioSource;

    public AudioClip[] hitAudios;
    public GameObject hitParticlesPrefab;
    
    

    private void Start() {
        
    }

    private void OnTriggerEnter(Collider other) {
        if (other.CompareTag("CubeShatter")) {
            var collisionPoint = other.ClosestPoint(transform.position);
            GameObject gb = Instantiate(hitParticlesPrefab, collisionPoint, Quaternion.identity);
            gb.GetComponent<ParticleSystem>().Play();
            Destroy(gb, 1f);
            Rigidbody rb = other.GetComponent<Rigidbody>();
            Destroy(rb);
            SendHapticFeedback();
            PlayRandomHitSound();
            gameManager.IncreaseScore();
            other.gameObject.GetComponent<BoxCollider>().enabled = false;
            other.gameObject.GetComponent<BoxMovement>().enabled = false;
            other.gameObject.GetComponent<ShatterExplosion>().Explode(other.transform);
        }
    }

    private void SendHapticFeedback() {
        controller.SendHapticImpulse(0.5f, 0.2f);
    }

    private void PlayRandomHitSound() {
        hitSoundAudioSource.clip = hitAudios[UnityEngine.Random.Range(0, hitAudios.Length)];
        hitSoundAudioSource.Play();
    }
}
