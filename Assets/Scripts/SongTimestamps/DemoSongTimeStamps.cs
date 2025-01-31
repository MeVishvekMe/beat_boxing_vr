using System;
using UnityEngine;

public class DemoSongTimeStamps : MonoBehaviour {
    // Types of spawn boxes
    public GameObject singleHitBoxPrefab;
    public GameObject doubleHitBoxPrefab;
    public GameObject dodgeObject;
    public GameObject jumpObject;
    
    // Tutorial Objects
    public GameObject tutorialSingleLeftHitBoxPrefab;
    public GameObject tutorialSingleRightHitBoxPrefab;
    public GameObject tutorialDoubleHitBoxPrefab;
    public GameObject tutorialDodgeObject;
    public GameObject tutorialJumpObject;
    
    public Transform[] spawnPointsArray = new Transform[7];
    
    // TimeStamp array
    TimeStampDS[] timestamps = new TimeStampDS[24];
    
    // Method for returning the timestamp array
    public TimeStampDS[] ReturnTimeStampArray() {
        return timestamps;
    }

    private void Start() {
        timestamps[0] = new TimeStampDS(tutorialSingleRightHitBoxPrefab, 2.24f, spawnPointsArray[2]); // 00:02:12
        timestamps[1] = new TimeStampDS(tutorialSingleLeftHitBoxPrefab, 5.68f, spawnPointsArray[3]); // 00:05:34
        timestamps[2] = new TimeStampDS(tutorialSingleRightHitBoxPrefab, 8.44f, spawnPointsArray[2]); // 00:08:22
        timestamps[3] = new TimeStampDS(tutorialSingleLeftHitBoxPrefab, 9.48f, spawnPointsArray[3]); // 00:09:24
        timestamps[4] = new TimeStampDS(singleHitBoxPrefab, 11.24f, spawnPointsArray[0]); // 00:11:12
        timestamps[5] = new TimeStampDS(singleHitBoxPrefab, 13.32f, spawnPointsArray[0]); // 00:13:16
        timestamps[6] = new TimeStampDS(tutorialDoubleHitBoxPrefab, 16.80f, spawnPointsArray[4]); // 00:16:40
        timestamps[7] = new TimeStampDS(tutorialDoubleHitBoxPrefab, 19.52f, spawnPointsArray[5]); // 00:19:26
        timestamps[8] = new TimeStampDS(doubleHitBoxPrefab, 22.24f, spawnPointsArray[4]); // 00:22:12
        timestamps[9] = new TimeStampDS(doubleHitBoxPrefab, 24.64f, spawnPointsArray[5]); // 00:24:32
        timestamps[10] = new TimeStampDS(singleHitBoxPrefab, 26.70f, spawnPointsArray[0]); // 00:26:35
        timestamps[11] = new TimeStampDS(singleHitBoxPrefab, 29.52f, spawnPointsArray[4]); // 00:29:26
        timestamps[12] = new TimeStampDS(tutorialDodgeObject, 33.06f, spawnPointsArray[3]); // 00:33:03
        timestamps[13] = new TimeStampDS(tutorialDodgeObject, 35.40f, spawnPointsArray[0]); // 00:35:20
        timestamps[14] = new TimeStampDS(tutorialDodgeObject, 38.80f, spawnPointsArray[1]); // 00:38:40
        timestamps[15] = new TimeStampDS(tutorialJumpObject, 44.34f, spawnPointsArray[6]); // 00:44:17
        timestamps[16] = new TimeStampDS(doubleHitBoxPrefab, 47.10f, spawnPointsArray[4]); // 00:47:05
        timestamps[17] = new TimeStampDS(tutorialJumpObject, 49.82f, spawnPointsArray[6]); // 00:49:41
        timestamps[18] = new TimeStampDS(singleHitBoxPrefab, 55.36f, spawnPointsArray[0]); // 00:55:18
        timestamps[19] = new TimeStampDS(singleHitBoxPrefab, 58.06f, spawnPointsArray[1]); // 00:58:03
        timestamps[20] = new TimeStampDS(singleHitBoxPrefab, 60.88f, spawnPointsArray[2]); // 01:00:44
        timestamps[21] = new TimeStampDS(singleHitBoxPrefab, 62.20f, spawnPointsArray[3]); // 01:02:10
        timestamps[22] = new TimeStampDS(singleHitBoxPrefab, 63.56f, spawnPointsArray[2]); // 01:03:28
        timestamps[23] = new TimeStampDS(singleHitBoxPrefab, 64.90f, spawnPointsArray[3]); // 01:04:45
    }
}
