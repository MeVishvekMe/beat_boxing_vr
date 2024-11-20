using UnityEngine;
using System.Collections;

public class BoxMovement : MonoBehaviour {
    private Vector3 targetPosition = new Vector3(0, 0, -8);  // The target position (z = -8)
    private float moveDuration = 2f;  // Duration to reach the target

    void Start()
    {
        targetPosition = new Vector3(transform.position.x, transform.position.y, -8);
        StartCoroutine(MoveOverTime());
    }

    IEnumerator MoveOverTime()
    {
        Vector3 startPosition = transform.position;
        float elapsedTime = 0f;

        while (elapsedTime < moveDuration)
        {
            transform.position = Vector3.Lerp(startPosition, targetPosition, elapsedTime / moveDuration);
            elapsedTime += Time.deltaTime;
            yield return null;  // Wait for the next frame
        }

        // Ensure final position is exactly at the target
        transform.position = targetPosition;
    }
}