using UnityEngine;

public class PlayerHeight : MonoBehaviour {
    public static float PlayerHeightValue = 1.7f;
    
    public static void SetPlayerHeight() {
        PlayerHeightValue = Camera.main.transform.position.y;
        Debug.Log("Updated player height to " + PlayerHeightValue);
    }
}
