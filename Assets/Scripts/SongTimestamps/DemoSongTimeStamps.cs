using System;
using UnityEngine;

public class DemoSongTimeStamps : SongTimestamps {
    
    TimeStampDS[] timestamps = new TimeStampDS[130];
    
    // Method for returning the timestamp array
    public override TimeStampDS[] ReturnTimeStampArray() {
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
        timestamps[24] = new TimeStampDS(singleHitBoxPrefab, 66.32f, spawnPointsArray[0]); // 01:06:16
        timestamps[25] = new TimeStampDS(singleHitBoxPrefab, 67.02f, spawnPointsArray[1]); // 01:07:01
        timestamps[26] = new TimeStampDS(dodgeObject, 68.20f, spawnPointsArray[5]); // 01:08:10
        timestamps[27] = new TimeStampDS(singleHitBoxPrefab, 69.10f, spawnPointsArray[2]); // 01:09:05
        timestamps[28] = new TimeStampDS(singleHitBoxPrefab, 69.78f, spawnPointsArray[3]); // 01:09:39
        timestamps[29] = new TimeStampDS(dodgeObject, 70.76f, spawnPointsArray[4]); // 01:10:38
        timestamps[30] = new TimeStampDS(doubleHitBoxPrefab, 71.86f, spawnPointsArray[4]); // 01:11:43
        timestamps[31] = new TimeStampDS(singleHitBoxPrefab, 72.54f, spawnPointsArray[3]); // 01:12:27
        timestamps[32] = new TimeStampDS(dodgeObject, 73.60f, spawnPointsArray[6]); // 01:13:30
        timestamps[33] = new TimeStampDS(singleHitBoxPrefab, 74.62f, spawnPointsArray[2]); // 01:14:31
        timestamps[34] = new TimeStampDS(singleHitBoxPrefab, 75.30f, spawnPointsArray[3]); // 01:15:15
        timestamps[35] = new TimeStampDS(jumpObject, 77.36f, spawnPointsArray[6]); // 01:17:18
        timestamps[36] = new TimeStampDS(dodgeObject, 78.06f, spawnPointsArray[2]); // 01:18:03
        timestamps[37] = new TimeStampDS(singleHitBoxPrefab, 80.12f, spawnPointsArray[0]); // 01:20:06
        timestamps[38] = new TimeStampDS(singleHitBoxPrefab, 80.80f, spawnPointsArray[1]); // 01:20:40
        timestamps[39] = new TimeStampDS(jumpObject, 82.36f, spawnPointsArray[6]); // 01:22:18
        timestamps[40] = new TimeStampDS(singleHitBoxPrefab, 82.96f, spawnPointsArray[0]); // 01:22:48
        timestamps[41] = new TimeStampDS(singleHitBoxPrefab, 83.68f, spawnPointsArray[2]); // 01:23:34
        timestamps[42] = new TimeStampDS(singleHitBoxPrefab, 85.72f, spawnPointsArray[1]); // 01:25:36
        timestamps[43] = new TimeStampDS(singleHitBoxPrefab, 86.38f, spawnPointsArray[3]); // 01:26:19
        timestamps[44] = new TimeStampDS(singleHitBoxPrefab, 88.42f, spawnPointsArray[0]); // 01:28:21
        timestamps[45] = new TimeStampDS(doubleHitBoxPrefab, 90.48f, spawnPointsArray[4]); // 01:30:24
        timestamps[46] = new TimeStampDS(dodgeObject, 91.88f, spawnPointsArray[2]); // 01:31:44
        timestamps[47] = new TimeStampDS(doubleHitBoxPrefab, 93.24f, spawnPointsArray[5]); // 01:33:12
        timestamps[48] = new TimeStampDS(jumpObject, 94.58f, spawnPointsArray[6]); // 01:34:29
        timestamps[49] = new TimeStampDS(doubleHitBoxPrefab, 96.00f, spawnPointsArray[4]); // 01:36:00
        timestamps[50] = new TimeStampDS(dodgeObject, 97.40f, spawnPointsArray[4]); // 01:37:20
        timestamps[51] = new TimeStampDS(doubleHitBoxPrefab, 98.74f, spawnPointsArray[4]); // 01:38:37
        timestamps[52] = new TimeStampDS(singleHitBoxPrefab, 100.08f, spawnPointsArray[1]); // 01:40:04
        timestamps[53] = new TimeStampDS(doubleHitBoxPrefab, 101.54f, spawnPointsArray[5]); // 01:41:27
        timestamps[54] = new TimeStampDS(singleHitBoxPrefab, 104.32f, spawnPointsArray[0]); // 01:44:16
        timestamps[55] = new TimeStampDS(singleHitBoxPrefab, 106.20f, spawnPointsArray[1]); // 01:46:10
        timestamps[56] = new TimeStampDS(singleHitBoxPrefab, 107.66f, spawnPointsArray[2]); // 01:47:33
        timestamps[57] = new TimeStampDS(singleHitBoxPrefab, 109.14f, spawnPointsArray[3]); // 01:49:07
        timestamps[58] = new TimeStampDS(jumpObject, 110.44f, spawnPointsArray[6]); // 01:50:22
        timestamps[59] = new TimeStampDS(singleHitBoxPrefab, 112.60f, spawnPointsArray[0]); // 01:52:30
        timestamps[60] = new TimeStampDS(singleHitBoxPrefab, 113.96f, spawnPointsArray[1]); // 01:53:48
        timestamps[61] = new TimeStampDS(singleHitBoxPrefab, 115.38f, spawnPointsArray[2]); // 01:55:19
        timestamps[62] = new TimeStampDS(singleHitBoxPrefab, 116.72f, spawnPointsArray[3]); // 01:56:36
        timestamps[63] = new TimeStampDS(singleHitBoxPrefab, 118.10f, spawnPointsArray[2]); // 01:58:05
        timestamps[64] = new TimeStampDS(singleHitBoxPrefab, 119.44f, spawnPointsArray[3]); // 01:59:22
        timestamps[65] = new TimeStampDS(singleHitBoxPrefab, 120.86f, spawnPointsArray[2]); // 02:00:43
        timestamps[66] = new TimeStampDS(singleHitBoxPrefab, 122.18f, spawnPointsArray[3]); // 02:02:09
        timestamps[67] = new TimeStampDS(singleHitBoxPrefab, 123.62f, spawnPointsArray[0]); // 02:03:31
        timestamps[68] = new TimeStampDS(singleHitBoxPrefab, 124.98f, spawnPointsArray[1]); // 02:04:49
        timestamps[69] = new TimeStampDS(singleHitBoxPrefab, 126.34f, spawnPointsArray[0]); // 02:06:17
        timestamps[70] = new TimeStampDS(singleHitBoxPrefab, 127.70f, spawnPointsArray[1]); // 02:07:35
        timestamps[71] = new TimeStampDS(singleHitBoxPrefab, 129.10f, spawnPointsArray[0]); // 02:09:05
        timestamps[72] = new TimeStampDS(singleHitBoxPrefab, 130.48f, spawnPointsArray[1]); // 02:10:24
        timestamps[73] = new TimeStampDS(singleHitBoxPrefab, 131.84f, spawnPointsArray[0]); // 02:11:42
        timestamps[74] = new TimeStampDS(singleHitBoxPrefab, 133.22f, spawnPointsArray[1]); // 02:13:11
        timestamps[75] = new TimeStampDS(singleHitBoxPrefab, 134.60f, spawnPointsArray[0]); // 02:14:30
        timestamps[76] = new TimeStampDS(singleHitBoxPrefab, 135.98f, spawnPointsArray[1]); // 02:15:49
        timestamps[77] = new TimeStampDS(singleHitBoxPrefab, 137.38f, spawnPointsArray[2]); // 02:17:19
        timestamps[78] = new TimeStampDS(singleHitBoxPrefab, 138.80f, spawnPointsArray[3]); // 02:18:40
        timestamps[79] = new TimeStampDS(singleHitBoxPrefab, 140.20f, spawnPointsArray[2]); // 02:20:10
        timestamps[80] = new TimeStampDS(singleHitBoxPrefab, 141.52f, spawnPointsArray[3]); // 02:21:26
        timestamps[81] = new TimeStampDS(jumpObject, 143.62f, spawnPointsArray[6]); // 02:23:31
        timestamps[82] = new TimeStampDS(singleHitBoxPrefab, 144.86f, spawnPointsArray[1]); // 02:24:43
        timestamps[83] = new TimeStampDS(singleHitBoxPrefab, 146.32f, spawnPointsArray[0]); // 02:26:16
        timestamps[84] = new TimeStampDS(singleHitBoxPrefab, 147.64f, spawnPointsArray[3]); // 02:27:32
        timestamps[85] = new TimeStampDS(jumpObject, 149.08f, spawnPointsArray[6]); // 02:29:04
        timestamps[86] = new TimeStampDS(singleHitBoxPrefab, 150.48f, spawnPointsArray[4]); // 02:30:24
        timestamps[87] = new TimeStampDS(dodgeObject, 151.86f, spawnPointsArray[5]); // 02:31:43
        timestamps[88] = new TimeStampDS(singleHitBoxPrefab, 153.18f, spawnPointsArray[0]); // 02:33:09
        timestamps[89] = new TimeStampDS(doubleHitBoxPrefab, 154.62f, spawnPointsArray[1]); // 02:34:31
        timestamps[90] = new TimeStampDS(singleHitBoxPrefab, 156.00f, spawnPointsArray[2]); // 02:36:00
        timestamps[91] = new TimeStampDS(doubleHitBoxPrefab, 157.38f, spawnPointsArray[3]); // 02:37:19
        timestamps[92] = new TimeStampDS(singleHitBoxPrefab, 158.78f, spawnPointsArray[3]); // 02:38:39
        timestamps[93] = new TimeStampDS(singleHitBoxPrefab, 160.12f, spawnPointsArray[2]); // 02:40:06
        timestamps[94] = new TimeStampDS(singleHitBoxPrefab, 161.52f, spawnPointsArray[1]); // 02:41:26
        timestamps[95] = new TimeStampDS(singleHitBoxPrefab, 162.88f, spawnPointsArray[0]); // 02:42:44
        timestamps[96] = new TimeStampDS(singleHitBoxPrefab, 164.26f, spawnPointsArray[5]); // 02:44:13
        timestamps[97] = new TimeStampDS(jumpObject, 165.64f, spawnPointsArray[6]); // 02:45:32
        timestamps[98] = new TimeStampDS(singleHitBoxPrefab, 167.00f, spawnPointsArray[0]); // 02:47:00
        timestamps[99] = new TimeStampDS(singleHitBoxPrefab, 168.40f, spawnPointsArray[2]); // 02:48:20
        timestamps[100] = new TimeStampDS(singleHitBoxPrefab, 169.78f, spawnPointsArray[1]); // 02:49:39
        timestamps[101] = new TimeStampDS(singleHitBoxPrefab, 171.16f, spawnPointsArray[3]); // 02:51:08
        timestamps[102] = new TimeStampDS(singleHitBoxPrefab, 172.52f, spawnPointsArray[0]); // 02:52:26
        timestamps[103] = new TimeStampDS(singleHitBoxPrefab, 173.88f, spawnPointsArray[1]); // 02:53:44
        timestamps[104] = new TimeStampDS(singleHitBoxPrefab, 174.58f, spawnPointsArray[2]); // 02:54:29
        timestamps[105] = new TimeStampDS(singleHitBoxPrefab, 175.30f, spawnPointsArray[3]); // 02:55:15
        timestamps[106] = new TimeStampDS(singleHitBoxPrefab, 176.00f, spawnPointsArray[3]); // 02:56:00
        timestamps[107] = new TimeStampDS(singleHitBoxPrefab, 176.70f, spawnPointsArray[2]); // 02:56:35
        timestamps[108] = new TimeStampDS(singleHitBoxPrefab, 178.04f, spawnPointsArray[1]); // 02:58:02
        timestamps[109] = new TimeStampDS(singleHitBoxPrefab, 179.44f, spawnPointsArray[0]); // 02:59:22
        timestamps[110] = new TimeStampDS(singleHitBoxPrefab, 180.80f, spawnPointsArray[1]); // 03:00:40
        timestamps[111] = new TimeStampDS(singleHitBoxPrefab, 182.16f, spawnPointsArray[2]); // 03:02:08
        timestamps[112] = new TimeStampDS(singleHitBoxPrefab, 183.56f, spawnPointsArray[3]); // 03:03:28
        timestamps[113] = new TimeStampDS(singleHitBoxPrefab, 184.84f, spawnPointsArray[2]); // 03:04:42
        timestamps[114] = new TimeStampDS(singleHitBoxPrefab, 185.58f, spawnPointsArray[1]); // 03:05:29
        timestamps[115] = new TimeStampDS(singleHitBoxPrefab, 186.30f, spawnPointsArray[0]); // 03:06:15
        timestamps[116] = new TimeStampDS(singleHitBoxPrefab, 187.02f, spawnPointsArray[4]); // 03:07:01
        timestamps[117] = new TimeStampDS(jumpObject, 187.74f, spawnPointsArray[6]); // 03:07:37
        timestamps[118] = new TimeStampDS(singleHitBoxPrefab, 189.10f, spawnPointsArray[0]); // 03:09:05
        timestamps[119] = new TimeStampDS(singleHitBoxPrefab, 190.46f, spawnPointsArray[1]); // 03:10:23
        timestamps[120] = new TimeStampDS(dodgeObject, 193.24f, spawnPointsArray[0]); // 03:13:12
        timestamps[121] = new TimeStampDS(singleHitBoxPrefab, 194.66f, spawnPointsArray[4]); // 03:14:33
        timestamps[122] = new TimeStampDS(singleHitBoxPrefab, 195.96f, spawnPointsArray[2]); // 03:15:48
        timestamps[123] = new TimeStampDS(jumpObject, 198.74f, spawnPointsArray[6]); // 03:18:37
        timestamps[124] = new TimeStampDS(singleHitBoxPrefab, 201.52f, spawnPointsArray[0]); // 03:21:26
        timestamps[125] = new TimeStampDS(dodgeObject, 204.28f, spawnPointsArray[2]); // 03:24:14
        timestamps[126] = new TimeStampDS(dodgeObject, 206.34f, spawnPointsArray[4]); // 03:26:17
        timestamps[127] = new TimeStampDS(dodgeObject, 208.22f, spawnPointsArray[6]); // 03:28:11
        timestamps[128] = new TimeStampDS(dodgeObject, 209.84f, spawnPointsArray[2]); // 03:29:42
        timestamps[129] = new TimeStampDS(doubleHitBoxPrefab, 213.08f, spawnPointsArray[5]); // 03:33:04
    }
}
