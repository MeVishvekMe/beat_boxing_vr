using UnityEngine;

public class ShatterExplosion : MonoBehaviour {
    public Transform explodePoint;
    
    public void Explode(Transform punch) {
        foreach (Transform child in transform) {
            Destroy(child.gameObject, 5f);
            Rigidbody childRB = child.gameObject.AddComponent<Rigidbody>();
            childRB.useGravity = false;
            // Calculate force direction away from punch
            Vector3 forceDirection = (childRB.position - punch.position).normalized;

            // Apply force in the calculated direction
            childRB.AddForce(forceDirection * 25f, ForceMode.Impulse);

            // Apply an explosion force
            childRB.AddExplosionForce(100f, explodePoint.position, 2f);
        }
    }
}
