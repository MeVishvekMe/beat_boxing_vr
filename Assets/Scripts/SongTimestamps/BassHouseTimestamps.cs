using System;
using UnityEngine;

public class BassHouseTimestamps : MonoBehaviour {
    // Types of spawn boxes
    public GameObject singleHitBoxPrefab;
    public GameObject doubleHitBoxPrefab;
    public GameObject dodgeObject;
    public GameObject jumpObject;
    
    public Transform[] spawnPointsArray = new Transform[7];
    
    // TimeStamp array
    TimeStampDS[] timestamps = new TimeStampDS[62];
    
    // Method for returning the timestamp array
    public TimeStampDS[] ReturnTimeStampArray() {
        return timestamps;
    }

    // Hard-coding values
    private void Start() {
        timestamps[0] = new TimeStampDS(singleHitBoxPrefab, 2.40f, spawnPointsArray[0]); // 00:02:20
        timestamps[1] = new TimeStampDS(singleHitBoxPrefab, 2.84f, spawnPointsArray[1]); // 00:02:42
        timestamps[2] = new TimeStampDS(singleHitBoxPrefab, 3.30f, spawnPointsArray[2]); // 00:03:15
        timestamps[3] = new TimeStampDS(singleHitBoxPrefab, 3.76f, spawnPointsArray[3]); // 00:03:38
        timestamps[4] = new TimeStampDS(singleHitBoxPrefab, 4.20f, spawnPointsArray[0]); // 00:04:10
        timestamps[5] = new TimeStampDS(singleHitBoxPrefab, 4.66f, spawnPointsArray[1]); // 00:04:33
        timestamps[6] = new TimeStampDS(singleHitBoxPrefab, 5.12f, spawnPointsArray[2]); // 00:05:06
        timestamps[7] = new TimeStampDS(singleHitBoxPrefab, 5.58f, spawnPointsArray[3]); // 00:05:29
        timestamps[8] = new TimeStampDS(singleHitBoxPrefab, 6.02f, spawnPointsArray[0]); // 00:06:01
        timestamps[9] = new TimeStampDS(singleHitBoxPrefab, 6.48f, spawnPointsArray[2]); // 00:06:24
        timestamps[10] = new TimeStampDS(singleHitBoxPrefab, 6.94f, spawnPointsArray[1]); // 00:06:47
        timestamps[11] = new TimeStampDS(singleHitBoxPrefab, 7.40f, spawnPointsArray[3]); // 00:07:20
        timestamps[12] = new TimeStampDS(singleHitBoxPrefab, 7.84f, spawnPointsArray[0]); // 00:07:42
        timestamps[13] = new TimeStampDS(singleHitBoxPrefab, 8.30f, spawnPointsArray[2]); // 00:08:15
        timestamps[14] = new TimeStampDS(singleHitBoxPrefab, 8.76f, spawnPointsArray[1]); // 00:08:38
        timestamps[15] = new TimeStampDS(singleHitBoxPrefab, 9.22f, spawnPointsArray[3]); // 00:09:11
        timestamps[16] = new TimeStampDS(singleHitBoxPrefab, 9.68f, spawnPointsArray[2]); // 00:09:34
        timestamps[17] = new TimeStampDS(singleHitBoxPrefab, 10.12f, spawnPointsArray[3]); // 00:10:06
        timestamps[18] = new TimeStampDS(singleHitBoxPrefab, 10.58f, spawnPointsArray[2]); // 00:10:29
        timestamps[19] = new TimeStampDS(singleHitBoxPrefab, 11.02f, spawnPointsArray[3]); // 00:11:01
        timestamps[20] = new TimeStampDS(singleHitBoxPrefab, 11.48f, spawnPointsArray[2]); // 00:11:24
        timestamps[21] = new TimeStampDS(singleHitBoxPrefab, 11.94f, spawnPointsArray[3]); // 00:11:47
        timestamps[22] = new TimeStampDS(singleHitBoxPrefab, 12.38f, spawnPointsArray[0]); // 00:12:19
        timestamps[23] = new TimeStampDS(singleHitBoxPrefab, 12.84f, spawnPointsArray[1]); // 00:12:42
        timestamps[24] = new TimeStampDS(singleHitBoxPrefab, 13.30f, spawnPointsArray[0]); // 00:13:15
        timestamps[25] = new TimeStampDS(singleHitBoxPrefab, 13.76f, spawnPointsArray[1]); // 00:13:38
        timestamps[26] = new TimeStampDS(singleHitBoxPrefab, 14.20f, spawnPointsArray[0]); // 00:14:10
        timestamps[27] = new TimeStampDS(jumpObject, 14.66f, spawnPointsArray[6]); // 00:14:33
        timestamps[28] = new TimeStampDS(jumpObject, 16.48f, spawnPointsArray[6]); // 00:16:24
        timestamps[29] = new TimeStampDS(jumpObject, 18.30f, spawnPointsArray[6]); // 00:18:15
        timestamps[30] = new TimeStampDS(jumpObject, 20.12f, spawnPointsArray[6]); // 00:20:06
        timestamps[31] = new TimeStampDS(jumpObject, 21.94f, spawnPointsArray[6]); // 00:21:47
        timestamps[32] = new TimeStampDS(jumpObject, 23.74f, spawnPointsArray[6]); // 00:23:37
        timestamps[33] = new TimeStampDS(jumpObject, 25.58f, spawnPointsArray[6]); // 00:25:29
        timestamps[34] = new TimeStampDS(jumpObject, 27.40f, spawnPointsArray[6]); // 00:27:20
        timestamps[35] = new TimeStampDS(doubleHitBoxPrefab, 29.22f, spawnPointsArray[4]); // 00:29:11
        timestamps[36] = new TimeStampDS(doubleHitBoxPrefab, 31.02f, spawnPointsArray[5]); // 00:31:01
        timestamps[37] = new TimeStampDS(doubleHitBoxPrefab, 32.84f, spawnPointsArray[4]); // 00:32:42
        timestamps[38] = new TimeStampDS(doubleHitBoxPrefab, 34.66f, spawnPointsArray[5]); // 00:34:33
        timestamps[39] = new TimeStampDS(dodgeObject, 36.48f, spawnPointsArray[0]); // 00:36:24
        timestamps[40] = new TimeStampDS(dodgeObject, 38.30f, spawnPointsArray[1]); // 00:38:15
        timestamps[41] = new TimeStampDS(singleHitBoxPrefab, 40.12f, spawnPointsArray[0]); // 00:40:06
        timestamps[42] = new TimeStampDS(singleHitBoxPrefab, 40.52f, spawnPointsArray[1]); // 00:40:26
        timestamps[43] = new TimeStampDS(singleHitBoxPrefab, 40.80f, spawnPointsArray[2]); // 00:40:40
        timestamps[44] = new TimeStampDS(singleHitBoxPrefab, 41.02f, spawnPointsArray[3]); // 00:41:01
        timestamps[45] = new TimeStampDS(singleHitBoxPrefab, 41.26f, spawnPointsArray[0]); // 00:41:13
        timestamps[46] = new TimeStampDS(singleHitBoxPrefab, 41.48f, spawnPointsArray[1]); // 00:41:24
        timestamps[47] = new TimeStampDS(singleHitBoxPrefab, 41.94f, spawnPointsArray[2]); // 00:41:47
        timestamps[48] = new TimeStampDS(singleHitBoxPrefab, 43.76f, spawnPointsArray[3]); // 00:43:38
        timestamps[49] = new TimeStampDS(singleHitBoxPrefab, 45.58f, spawnPointsArray[2]); // 00:45:29
        timestamps[50] = new TimeStampDS(singleHitBoxPrefab, 46.04f, spawnPointsArray[3]); // 00:46:02
        timestamps[51] = new TimeStampDS(singleHitBoxPrefab, 46.50f, spawnPointsArray[4]); // 00:46:25
        timestamps[52] = new TimeStampDS(jumpObject, 47.40f, spawnPointsArray[6]); // 00:47:20
        timestamps[53] = new TimeStampDS(singleHitBoxPrefab, 47.84f, spawnPointsArray[0]); // 00:47:42
        timestamps[54] = new TimeStampDS(singleHitBoxPrefab, 48.76f, spawnPointsArray[1]); // 00:48:38
        timestamps[55] = new TimeStampDS(singleHitBoxPrefab, 48.98f, spawnPointsArray[0]); // 00:48:49
        timestamps[56] = new TimeStampDS(singleHitBoxPrefab, 49.66f, spawnPointsArray[1]); // 00:49:33
        timestamps[57] = new TimeStampDS(singleHitBoxPrefab, 49.88f, spawnPointsArray[0]); // 00:49:44
        timestamps[58] = new TimeStampDS(singleHitBoxPrefab, 50.34f, spawnPointsArray[1]); // 00:50:17
        timestamps[59] = new TimeStampDS(singleHitBoxPrefab, 50.56f, spawnPointsArray[0]); // 00:50:28
        timestamps[60] = new TimeStampDS(jumpObject, 51.04f, spawnPointsArray[6]); // 00:51:02
        timestamps[61] = new TimeStampDS(singleHitBoxPrefab, 51.48f, spawnPointsArray[0]); // 00:51:24

    }
}
