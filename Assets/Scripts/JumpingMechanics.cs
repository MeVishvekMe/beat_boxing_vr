using System;
using UnityEngine;

public class JumpingMechanics : MonoBehaviour {
    private float playerHeight;
    private float currentHeight;

    public static GameObject Instance;

    private void Start() {
        Instance = this.gameObject;
        Invoke("CalculatePlayerLocalHeight", 2f);
    }

    private void Update() {
        currentHeight = transform.localPosition.y;
    }

    private void CalculatePlayerLocalHeight() {
        playerHeight = transform.localPosition.y;
    }


    public float GetCurrentPlayerHeight() {
        return currentHeight;
    }
    
}
