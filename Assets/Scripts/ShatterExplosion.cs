using System;
using UnityEngine;

public class ShatterExplosion : MonoBehaviour {
    public Transform explodePoint;
    public bool[] explode = new bool[2];

    private void Start() {
        explode[0] = false;
        explode[1] = false;
    }

    public void Explode(Transform punch) {
        BoxExplode(punch);
    }

    public bool DoubleExplode(Transform punch) {
        if (explode[0] && explode[1]) {
            GetComponent<BoxCollider>().enabled = false;
            GetComponent<BoxMovement>().enabled = false;
            BoxExplode(punch);
            return true;
        }
        else {
            return false;
        }
    }

    private void BoxExplode(Transform punch) {
        foreach (Transform child in transform) {
            Destroy(child.gameObject, 5f);
            Rigidbody childRB = child.gameObject.AddComponent<Rigidbody>();
            childRB.useGravity = false;
            // Calculate force direction away from punch
            Vector3 forceDirection = (childRB.position - punch.position).normalized;

            // Apply force in the calculated direction
            childRB.AddForce(forceDirection * 10f, ForceMode.Impulse);

            // Apply an explosion force
            childRB.AddExplosionForce(60f, explodePoint.position, 2f);
        }
        Destroy(gameObject, 2f);
    }
}
