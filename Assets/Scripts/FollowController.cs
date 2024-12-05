using System;
using UnityEngine;

public class FollowController : MonoBehaviour {
    
    // This script is for the boxing gloves to follow the controller
    
    public GameObject controller;
    

    private void Update() {
        transform.position = controller.transform.position;
        transform.rotation = controller.transform.rotation;
    }
}
