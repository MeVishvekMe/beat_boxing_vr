using System;
using UnityEngine;
using System.Collections;

public class BoxMovement : MonoBehaviour {
    private Rigidbody _rb;

    private void Start() {
        _rb = GetComponent<Rigidbody>();
        _rb.linearVelocity = new Vector3(0, 0, -6.75f);
    }
    
}