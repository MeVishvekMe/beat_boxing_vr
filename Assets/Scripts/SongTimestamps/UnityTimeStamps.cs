using UnityEngine;

public class UnityTimeStamps : MonoBehaviour {
    // Types of spawn boxes
    public GameObject singleHitBoxPrefab;
    public GameObject doubleHitBoxPrefab;
    
    // Spawn points of the boxes
    public Transform pLeftLeft;
    public Transform pRightRight;
    public Transform pLeft;
    public Transform pRight;
    public Transform pMiddle;
    public Transform pMiddle2;
    public Transform[] spawnPointsArray = new Transform[6];
    
    // TimeStamp array
    TimeStampDS[] timestamps = new TimeStampDS[102];
    
    // Method for returning the timestamp array
    public TimeStampDS[] ReturnTimeStampArray() {
        return timestamps;
    }

    // Hard-coding values
    void Start() {
        spawnPointsArray[0] = pLeftLeft;
        spawnPointsArray[1] = pRightRight;
        spawnPointsArray[2] = pLeft;
        spawnPointsArray[3] = pRight;
        spawnPointsArray[4] = pMiddle;
        spawnPointsArray[5] = pMiddle2;
        
        timestamps[0] = new TimeStampDS(singleHitBoxPrefab, 4.20f, spawnPointsArray[2]); // 00:04:10
        timestamps[1] = new TimeStampDS(singleHitBoxPrefab, 4.20f, spawnPointsArray[3]); // 00:04:10
        timestamps[2] = new TimeStampDS(singleHitBoxPrefab, 4.78f, spawnPointsArray[0]); // 00:04:39
        timestamps[3] = new TimeStampDS(singleHitBoxPrefab, 5.24f, spawnPointsArray[1]); // 00:05:12
        timestamps[4] = new TimeStampDS(singleHitBoxPrefab, 6.50f, spawnPointsArray[2]); // 00:06:25
        timestamps[5] = new TimeStampDS(singleHitBoxPrefab, 6.50f, spawnPointsArray[3]); // 00:06:25
        timestamps[6] = new TimeStampDS(singleHitBoxPrefab, 7.06f, spawnPointsArray[0]); // 00:07:03
        timestamps[7] = new TimeStampDS(singleHitBoxPrefab, 7.34f, spawnPointsArray[1]); // 00:07:17
        timestamps[8] = new TimeStampDS(singleHitBoxPrefab, 7.64f, spawnPointsArray[2]); // 00:07:32
        timestamps[9] = new TimeStampDS(singleHitBoxPrefab, 7.90f, spawnPointsArray[3]); // 00:07:45
        timestamps[10] = new TimeStampDS(singleHitBoxPrefab, 8.20f, spawnPointsArray[2]); // 00:08:10
        timestamps[11] = new TimeStampDS(singleHitBoxPrefab, 8.20f, spawnPointsArray[3]); // 00:08:10
        timestamps[12] = new TimeStampDS(doubleHitBoxPrefab, 9.34f, spawnPointsArray[4]); // 00:09:17
        timestamps[13] = new TimeStampDS(doubleHitBoxPrefab, 10.48f, spawnPointsArray[5]); // 00:10:24
        timestamps[14] = new TimeStampDS(singleHitBoxPrefab, 11.62f, spawnPointsArray[0]); // 00:11:31
        timestamps[15] = new TimeStampDS(singleHitBoxPrefab, 11.94f, spawnPointsArray[1]); // 00:11:47
        timestamps[16] = new TimeStampDS(singleHitBoxPrefab, 12.20f, spawnPointsArray[2]); // 00:12:10
        timestamps[17] = new TimeStampDS(singleHitBoxPrefab, 12.50f, spawnPointsArray[3]); // 00:12:25
        timestamps[18] = new TimeStampDS(singleHitBoxPrefab, 12.78f, spawnPointsArray[2]); // 00:12:39
        timestamps[19] = new TimeStampDS(singleHitBoxPrefab, 12.78f, spawnPointsArray[3]); // 00:12:39
        timestamps[20] = new TimeStampDS(doubleHitBoxPrefab, 13.92f, spawnPointsArray[4]); // 00:13:46
        timestamps[21] = new TimeStampDS(doubleHitBoxPrefab, 15.08f, spawnPointsArray[5]); // 00:15:04
        timestamps[22] = new TimeStampDS(singleHitBoxPrefab, 16.22f, spawnPointsArray[0]); // 00:16:11
        timestamps[23] = new TimeStampDS(singleHitBoxPrefab, 16.50f, spawnPointsArray[1]); // 00:16:25
        timestamps[24] = new TimeStampDS(singleHitBoxPrefab, 16.78f, spawnPointsArray[2]); // 00:16:39
        timestamps[25] = new TimeStampDS(singleHitBoxPrefab, 17.06f, spawnPointsArray[3]); // 00:17:03
        timestamps[26] = new TimeStampDS(singleHitBoxPrefab, 17.36f, spawnPointsArray[2]); // 00:17:18
        timestamps[27] = new TimeStampDS(singleHitBoxPrefab, 17.36f, spawnPointsArray[3]); // 00:17:18
        timestamps[28] = new TimeStampDS(doubleHitBoxPrefab, 18.50f, spawnPointsArray[4]); // 00:18:25
        timestamps[29] = new TimeStampDS(doubleHitBoxPrefab, 19.66f, spawnPointsArray[5]); // 00:19:33
        timestamps[30] = new TimeStampDS(singleHitBoxPrefab, 20.80f, spawnPointsArray[0]); // 00:20:40
        timestamps[31] = new TimeStampDS(singleHitBoxPrefab, 21.08f, spawnPointsArray[1]); // 00:21:04
        timestamps[32] = new TimeStampDS(singleHitBoxPrefab, 21.26f, spawnPointsArray[2]); // 00:21:13
        timestamps[33] = new TimeStampDS(singleHitBoxPrefab, 21.64f, spawnPointsArray[3]); // 00:21:32
        timestamps[34] = new TimeStampDS(singleHitBoxPrefab, 21.92f, spawnPointsArray[2]); // 00:21:46
        timestamps[35] = new TimeStampDS(singleHitBoxPrefab, 21.92f, spawnPointsArray[3]); // 00:21:46
        timestamps[36] = new TimeStampDS(doubleHitBoxPrefab, 23.06f, spawnPointsArray[4]); // 00:23:03
        timestamps[37] = new TimeStampDS(doubleHitBoxPrefab, 24.22f, spawnPointsArray[5]); // 00:24:11
        timestamps[38] = new TimeStampDS(singleHitBoxPrefab, 25.34f, spawnPointsArray[3]); // 00:25:17
        timestamps[39] = new TimeStampDS(singleHitBoxPrefab, 25.64f, spawnPointsArray[2]); // 00:25:32
        timestamps[40] = new TimeStampDS(singleHitBoxPrefab, 25.92f, spawnPointsArray[1]); // 00:25:46
        timestamps[41] = new TimeStampDS(singleHitBoxPrefab, 26.20f, spawnPointsArray[0]); // 00:26:10
        timestamps[42] = new TimeStampDS(singleHitBoxPrefab, 26.50f, spawnPointsArray[4]); // 00:26:25
        timestamps[43] = new TimeStampDS(singleHitBoxPrefab, 26.50f, spawnPointsArray[5]); // 00:26:25
        timestamps[44] = new TimeStampDS(singleHitBoxPrefab, 27.54f, spawnPointsArray[0]); // 00:27:27
        timestamps[45] = new TimeStampDS(doubleHitBoxPrefab, 28.22f, spawnPointsArray[4]); // 00:28:11
        timestamps[46] = new TimeStampDS(singleHitBoxPrefab, 28.76f, spawnPointsArray[1]); // 00:28:38
        timestamps[47] = new TimeStampDS(singleHitBoxPrefab, 29.36f, spawnPointsArray[2]); // 00:29:18
        timestamps[48] = new TimeStampDS(singleHitBoxPrefab, 29.36f, spawnPointsArray[3]); // 00:29:18
        timestamps[49] = new TimeStampDS(singleHitBoxPrefab, 29.92f, spawnPointsArray[2]); // 00:29:46
        timestamps[50] = new TimeStampDS(doubleHitBoxPrefab, 30.48f, spawnPointsArray[5]); // 00:30:24
        timestamps[51] = new TimeStampDS(singleHitBoxPrefab, 31.08f, spawnPointsArray[3]); // 00:31:04
        timestamps[52] = new TimeStampDS(singleHitBoxPrefab, 31.62f, spawnPointsArray[2]); // 00:31:31
        timestamps[53] = new TimeStampDS(singleHitBoxPrefab, 31.62f, spawnPointsArray[3]); // 00:31:31
        timestamps[54] = new TimeStampDS(singleHitBoxPrefab, 32.20f, spawnPointsArray[0]); // 00:32:10
        timestamps[55] = new TimeStampDS(doubleHitBoxPrefab, 32.78f, spawnPointsArray[4]); // 00:32:39
        timestamps[56] = new TimeStampDS(singleHitBoxPrefab, 33.38f, spawnPointsArray[1]); // 00:33:19
        timestamps[57] = new TimeStampDS(singleHitBoxPrefab, 33.92f, spawnPointsArray[2]); // 00:33:46
        timestamps[58] = new TimeStampDS(singleHitBoxPrefab, 33.92f, spawnPointsArray[3]); // 00:33:46
        timestamps[59] = new TimeStampDS(singleHitBoxPrefab, 34.52f, spawnPointsArray[2]); // 00:34:26
        timestamps[60] = new TimeStampDS(doubleHitBoxPrefab, 35.06f, spawnPointsArray[5]); // 00:35:03
        timestamps[61] = new TimeStampDS(singleHitBoxPrefab, 35.64f, spawnPointsArray[0]); // 00:35:32
        timestamps[62] = new TimeStampDS(singleHitBoxPrefab, 36.20f, spawnPointsArray[2]); // 00:36:10
        timestamps[63] = new TimeStampDS(singleHitBoxPrefab, 36.20f, spawnPointsArray[3]); // 00:36:10
        timestamps[64] = new TimeStampDS(singleHitBoxPrefab, 36.78f, spawnPointsArray[1]); // 00:36:39
        timestamps[65] = new TimeStampDS(doubleHitBoxPrefab, 37.34f, spawnPointsArray[4]); // 00:37:17
        timestamps[66] = new TimeStampDS(singleHitBoxPrefab, 37.92f, spawnPointsArray[0]); // 00:37:46
        timestamps[67] = new TimeStampDS(singleHitBoxPrefab, 38.48f, spawnPointsArray[2]); // 00:38:24
        timestamps[68] = new TimeStampDS(singleHitBoxPrefab, 38.48f, spawnPointsArray[3]); // 00:38:24
        timestamps[69] = new TimeStampDS(singleHitBoxPrefab, 39.08f, spawnPointsArray[2]); // 00:39:04
        timestamps[70] = new TimeStampDS(doubleHitBoxPrefab, 39.64f, spawnPointsArray[5]); // 00:39:32
        timestamps[71] = new TimeStampDS(singleHitBoxPrefab, 40.20f, spawnPointsArray[0]); // 00:40:10
        timestamps[72] = new TimeStampDS(doubleHitBoxPrefab, 40.78f, spawnPointsArray[4]); // 00:40:39
        timestamps[73] = new TimeStampDS(singleHitBoxPrefab, 41.34f, spawnPointsArray[2]); // 00:41:17
        timestamps[74] = new TimeStampDS(singleHitBoxPrefab, 41.34f, spawnPointsArray[3]); // 00:41:17
        timestamps[75] = new TimeStampDS(doubleHitBoxPrefab, 41.92f, spawnPointsArray[1]); // 00:41:46
        timestamps[76] = new TimeStampDS(singleHitBoxPrefab, 42.50f, spawnPointsArray[5]); // 00:42:25
        timestamps[77] = new TimeStampDS(doubleHitBoxPrefab, 43.06f, spawnPointsArray[0]); // 00:43:03
        timestamps[78] = new TimeStampDS(singleHitBoxPrefab, 43.62f, spawnPointsArray[2]); // 00:43:31
        timestamps[79] = new TimeStampDS(singleHitBoxPrefab, 43.92f, spawnPointsArray[1]); // 00:43:46
        timestamps[80] = new TimeStampDS(singleHitBoxPrefab, 44.20f, spawnPointsArray[3]); // 00:44:10
        timestamps[81] = new TimeStampDS(singleHitBoxPrefab, 44.48f, spawnPointsArray[4]); // 00:44:24
        timestamps[82] = new TimeStampDS(singleHitBoxPrefab, 44.76f, spawnPointsArray[5]); // 00:44:38
        timestamps[83] = new TimeStampDS(doubleHitBoxPrefab, 45.92f, spawnPointsArray[4]); // 00:45:46
        timestamps[84] = new TimeStampDS(doubleHitBoxPrefab, 47.06f, spawnPointsArray[5]); // 00:47:03
        timestamps[85] = new TimeStampDS(singleHitBoxPrefab, 48.20f, spawnPointsArray[0]); // 00:48:10
        timestamps[86] = new TimeStampDS(singleHitBoxPrefab, 48.48f, spawnPointsArray[1]); // 00:48:24
        timestamps[87] = new TimeStampDS(singleHitBoxPrefab, 48.76f, spawnPointsArray[2]); // 00:48:38
        timestamps[88] = new TimeStampDS(singleHitBoxPrefab, 49.06f, spawnPointsArray[3]); // 00:49:03
        timestamps[89] = new TimeStampDS(singleHitBoxPrefab, 49.34f, spawnPointsArray[4]); // 00:49:17
        timestamps[90] = new TimeStampDS(doubleHitBoxPrefab, 50.48f, spawnPointsArray[4]); // 00:50:24
        timestamps[91] = new TimeStampDS(doubleHitBoxPrefab, 51.64f, spawnPointsArray[5]); // 00:51:32
        timestamps[92] = new TimeStampDS(singleHitBoxPrefab, 52.78f, spawnPointsArray[0]); // 00:52:39
        timestamps[93] = new TimeStampDS(singleHitBoxPrefab, 53.06f, spawnPointsArray[2]); // 00:53:03
        timestamps[94] = new TimeStampDS(singleHitBoxPrefab, 53.34f, spawnPointsArray[1]); // 00:53:17
        timestamps[95] = new TimeStampDS(singleHitBoxPrefab, 53.62f, spawnPointsArray[3]); // 00:53:31
        timestamps[96] = new TimeStampDS(singleHitBoxPrefab, 53.92f, spawnPointsArray[5]); // 00:53:46




    }
}
