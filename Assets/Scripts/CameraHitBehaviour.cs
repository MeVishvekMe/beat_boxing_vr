using System;
using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class CameraHitBehaviour : MonoBehaviour {
    [SerializeField] private ScoreManager scoreManager;

    [SerializeField] private Image objectHitVisual;
    
    private void OnTriggerEnter(Collider other) {
        if (other.CompareTag("DodgeObject")) {
            Destroy(other.gameObject);
            HitVisualStart();
        }
    }

    public void HitVisualStart() {
        scoreManager.ResetMultiplier();
        StartCoroutine(HitVisualAnimation());
    }

    IEnumerator HitVisualAnimation() {
        objectHitVisual.gameObject.SetActive(true);

        // Get the current color of the image
        Color currentColor = objectHitVisual.color;

        // Duration of the fade-out effect
        float fadeDuration = 1.0f;

        // Loop to gradually reduce the alpha value over time
        for (float t = 0; t < fadeDuration; t += Time.deltaTime) {
            float normalizedTime = t / fadeDuration; // Normalize the time to a 0-1 range
            currentColor.a = Mathf.Lerp(1.0f, 0.0f, normalizedTime); // Interpolate alpha from 1 to 0
            objectHitVisual.color = currentColor;
            yield return null; // Wait for the next frame
        }

        // Ensure the final alpha is set to 0
        currentColor.a = 0.0f;
        objectHitVisual.color = currentColor;

        // Disable the image object
        objectHitVisual.gameObject.SetActive(false);
    }
}
