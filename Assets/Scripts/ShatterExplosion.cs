using UnityEngine;

public class ShatterExplosion : MonoBehaviour {
    public Transform explodePoint;

    private void Start() {
    }
    
    public void Explode() {
        foreach (Transform child in transform) {
            Rigidbody childRB = child.GetComponent<Rigidbody>();
            childRB = child.GetComponent<Rigidbody>();
            childRB.AddExplosionForce(100f, explodePoint.position, 2f);
        }
        
    }
}
