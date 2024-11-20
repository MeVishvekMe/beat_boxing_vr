using UnityEngine;

public class SpawnBox : MonoBehaviour {
    public GameObject boxPrefab;

    public Vector2 spawnRangeX;    // Random range for X position
    public Vector2 spawnRangeY;    // Random range for Y position
    public float targetZ = -8f;    // Target Z position
    public float spawnZ = 5.5f;    // Initial spawn Z position
    public float[] timestamps;     // Time when boxes should reach the target

    private int currentTimestampIndex = 0;  // To track which timestamp to spawn

    void Update() {
        Debug.Log(Time.time);
        // Check if it's time to spawn a box based on the timestamps
        if (currentTimestampIndex < timestamps.Length) {
            // Spawn 2 seconds earlier than the timestamp
            if (Time.time >= timestamps[currentTimestampIndex] - 1.8f) {
                SpawnBoxObject();
                currentTimestampIndex++;  // Move to the next timestamp
            }
        }
    }

    private void SpawnBoxObject() {
        float x = Random.Range(spawnRangeX.x, spawnRangeX.y);
        float y = Random.Range(spawnRangeY.x, spawnRangeY.y);
        GameObject box = Instantiate(boxPrefab, new Vector3(x, y, spawnZ), Quaternion.identity);
    }
}