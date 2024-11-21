using System;
using UnityEngine;
using Random = UnityEngine.Random;

public class SpawnBox : MonoBehaviour {
    
    public AudioSource audioSource;
    
    public GameObject boxPrefab;

    public Vector2 spawnRangeX;    // Random range for X position
    public Vector2 spawnRangeY;    // Random range for Y position
    // public float targetZ = -8f;    // Target Z position
    public float spawnZ = 5.5f;    // Initial spawn Z position
    public float[] timestamps;     // Time when boxes should reach the target

    private int _currentIndex = 0;

    private void Update() {
        Debug.Log(audioSource.time);
        if (audioSource.time >= timestamps[_currentIndex] - 2) {
            Debug.Log("spawning box");
            SpawnBoxObject();
            _currentIndex++;
        }
    }

    private void SpawnBoxObject() {
        float x = Random.Range(spawnRangeX.x, spawnRangeX.y);
        float y = Random.Range(spawnRangeY.x, spawnRangeY.y);
        GameObject box = Instantiate(boxPrefab, new Vector3(x, y, spawnZ), Quaternion.identity);
        Destroy(box, 10f);
    }
}