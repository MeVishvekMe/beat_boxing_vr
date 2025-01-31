using System;
using UnityEngine;
using UnityEngine.Serialization;
using UnityEngine.XR.Interaction.Toolkit.Inputs.Haptics;
using Random = UnityEngine.Random;

public class GloveScript : MonoBehaviour {
    public HapticImpulsePlayer controller;
    [FormerlySerializedAs("gameManager")] public ScoreManager scoreManager;
    public AudioSource hitSoundAudioSource;

    public AudioClip[] hitAudios;
    public GameObject[] hitParticlesPrefab;

    public int shatterIndex;

    private FollowController followController;

    private void Awake() {
        followController = GetComponent<FollowController>();
    }

    private void OnTriggerEnter(Collider other) {
        if (other.CompareTag("CubeShatter") && followController.GetSpeed() >= 1f) {
            TutorialObjectScript tutorialObjectScript = other.GetComponent<TutorialObjectScript>();
            if (tutorialObjectScript != null) {
                GameStateHandler.GameResume();
            }
            ExplodeCube(other);
        }
    }

    private void OnTriggerStay(Collider other) {
        if (other.CompareTag("CubeDouble") && followController.GetSpeed() >= 1f) {
            TutorialObjectScript tutorialObjectScript = other.GetComponent<TutorialObjectScript>();
            if (tutorialObjectScript != null) {
                GameStateHandler.GameResume();
            }
            HandleCubeDoubleCollision(other);
        }
    }

    private void OnTriggerExit(Collider other) {
        if (other.CompareTag("CubeDouble")) {
            var shatterExplosion = other.GetComponent<ShatterExplosion>();
            shatterExplosion.explode[shatterIndex] = false;
        }
    }

    private void HandleCubeDoubleCollision(Collider other) {
        var shatterExplosion = other.GetComponent<ShatterExplosion>();
        shatterExplosion.explode[shatterIndex] = true;

        if (shatterExplosion.DoubleExplode(other.transform)) {
            CreateParticleEffect(other);
            DisableCubePhysics(other);
            SendHapticFeedback();
            PlayRandomHitSound();
            scoreManager.IncreaseScore();
        }
    }

    private void ExplodeCube(Collider other) {
        CreateParticleEffect(other);
        DisableCubePhysics(other);
        SendHapticFeedback();
        PlayRandomHitSound();
        scoreManager.IncreaseScore();

        var cube = other.gameObject;
        cube.GetComponent<BoxCollider>().enabled = false;
        cube.GetComponent<BoxMovement>().enabled = false;
        cube.GetComponent<ShatterExplosion>().Explode(other.transform);
    }

    private void CreateParticleEffect(Collider other) {
        var collisionPoint = other.ClosestPoint(transform.position);
        int randomIndex = Random.Range(0, hitParticlesPrefab.Length);

        var particleEffect = Instantiate(hitParticlesPrefab[randomIndex], collisionPoint, Quaternion.identity);
        particleEffect.GetComponent<ParticleSystem>().Play();
        Destroy(particleEffect, 1f);
    }

    private void DisableCubePhysics(Collider other) {
        var rb = other.GetComponent<Rigidbody>();
        if (rb != null) Destroy(rb);
    }

    private void SendHapticFeedback() {
        controller.SendHapticImpulse(0.5f, 0.2f);
    }

    private void PlayRandomHitSound() {
        hitSoundAudioSource.clip = hitAudios[Random.Range(0, hitAudios.Length)];
        hitSoundAudioSource.Play();
    }
}
