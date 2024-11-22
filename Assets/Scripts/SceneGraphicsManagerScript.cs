using System;
using UnityEngine;

public class SceneGraphicsManagerScript : MonoBehaviour {
    
    // Spawn Points for graphic lines
    public Transform[] spawnPoints;
    
    public GameObject graphicLinePrefab;
    
    private float _time = 0f;

    private void Update() {
        _time += Time.deltaTime;
        if (_time >= 0.5f) {
            SpawnGraphicLines();
            _time = 0f;
        }
    }

    public void SpawnGraphicLines() {
        int i = 0;
        while (i < spawnPoints.Length) {
            GameObject line = Instantiate(graphicLinePrefab, spawnPoints[i].position, Quaternion.identity);
            Destroy(line, 10f);
            i++;
        }
    }

}
