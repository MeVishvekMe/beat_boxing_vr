using UnityEngine;

public class SpaceshipVisuals : MonoBehaviour
{
    public float minBound = -0.2f; // Minimum boundary for the position
    public float maxBound = 0.2f;  // Maximum boundary for the position
    public float moveSpeed = 1f;   // Speed of the movement

    private Vector3 targetPosition; // The target position to move toward

    void Start()
    {
        // Generate the initial target position
        GenerateRandomTarget();
    }

    void Update()
    {
        // Move smoothly toward the target position
        transform.localPosition = Vector3.Lerp(transform.localPosition, targetPosition, moveSpeed * Time.deltaTime);

        // Check if the object is close to the target position
        if (Vector3.Distance(transform.localPosition, targetPosition) < 0.01f)
        {
            // Generate a new random target position
            GenerateRandomTarget();
        }
    }

    // Generates a random target position within the bounds
    private void GenerateRandomTarget()
    {
        float randomX = Random.Range(minBound, maxBound);
        float randomY = Random.Range(-0.1f, 0.1f);
        float randomZ = Random.Range(minBound, maxBound);

        targetPosition = new Vector3(randomX, randomY, randomZ);
    }
}