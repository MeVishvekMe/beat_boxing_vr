using System;
using UnityEngine;

public class FollowController : MonoBehaviour {
    public GameObject controller;

    private void Update() {
        transform.position = controller.transform.position;
        transform.rotation = controller.transform.rotation;
    }
}
