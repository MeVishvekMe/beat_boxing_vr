using UnityEngine;

public class TimeStampDS {
    public GameObject spawnType;
    public float timeStamp;
    public Transform spawnPoint;

    public TimeStampDS(GameObject spawnType, float timeStamp, Transform spawnPoint) {
        this.spawnType = spawnType;
        this.timeStamp = timeStamp;
        this.spawnPoint = spawnPoint;
    }
}
