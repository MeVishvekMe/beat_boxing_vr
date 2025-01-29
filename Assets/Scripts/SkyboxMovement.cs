using System.Collections;
using UnityEngine;

public class SkyboxMovement : MonoBehaviour
{
    [SerializeField] private Material skybox;
    [SerializeField] private float rotationSpeed = 0.1f; // Speed of rotation in degrees per second

    private void Start()
    {
        if (skybox == null)
        {
            Debug.LogError("Skybox material is not assigned.");
            return;
        }

        StartCoroutine(MoveSkybox());
    }

    IEnumerator MoveSkybox()
    {
        float currentRotation = 0f;

        while (true)
        {
            // Increment the rotation based on time and speed
            currentRotation += rotationSpeed * Time.deltaTime;
            currentRotation %= 360f; // Keep rotation within 0-360 degrees

            // Set the rotation property in the skybox material
            skybox.SetFloat("_Rotation", currentRotation);

            yield return null; // Wait until the next frame
        }
    }
}