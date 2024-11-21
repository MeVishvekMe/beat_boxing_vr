using UnityEngine;

public class SceneGraphicsManagerScript : MonoBehaviour {
    
    // Spawn Points for graphic lines
    public Transform[] spawnPoints;
    
    public GameObject graphicLinePrefab;

    public void SpawnGraphicLines() {
        Debug.Log("Called");
        int i = 0;
        while (i < spawnPoints.Length) {
            GameObject line = Instantiate(graphicLinePrefab, spawnPoints[i].position, Quaternion.identity);
            i++;
        }
    }

}
