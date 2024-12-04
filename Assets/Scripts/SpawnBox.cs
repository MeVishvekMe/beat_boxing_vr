using System;
using UnityEngine;
using Random = UnityEngine.Random;

public class SpawnBox : MonoBehaviour {
    
    public AudioSource audioSource;
    
    public GameObject boxPrefab;
    public GameObject doubleBoxPrefab;

    public Vector2 spawnRangeX;    // Random range for X position
    public Vector2 spawnRangeY;    // Random range for Y position
    // public float targetZ = -8f;    // Target Z position
    public float spawnZ = 5.5f;    // Initial spawn Z position
    private float[] timestamps;  // Time when boxes should reach the target
    private float[] doubleTimestamps;

    public GameObject timeStampGameObject;
    private int _currentIndex = 0;
    private int _currentDoubleIndex = 0;
    
    private void Start() {
        timestamps = timeStampGameObject.GetComponent<GodishTimestamps>().ReturnTimeStampsArray();
        doubleTimestamps = timeStampGameObject.GetComponent<GodishTimestamps>().ReturnDoubleTimeStampsArray();
    }

    private void Update() {
        
        if (audioSource.time >= timestamps[_currentIndex] - 2) {
            SpawnBoxObject(boxPrefab);
            _currentIndex++;
        }

        if (audioSource.time >= doubleTimestamps[_currentDoubleIndex] - 2) {
            SpawnBoxObject(doubleBoxPrefab);
            _currentDoubleIndex++;
        }
    }
    
    

    private void SpawnBoxObject(GameObject obj) {
        float x = Random.Range(spawnRangeX.x, spawnRangeX.y);
        float y = Random.Range(spawnRangeY.x, spawnRangeY.y);
        GameObject box = Instantiate(obj, new Vector3(x, y, spawnZ), Quaternion.identity);
        Destroy(box, 10f);
    }
}