using System.Collections;
using UnityEngine;

public class DestroyMissile : MonoBehaviour {

	 public float lifetime;
 
    void Start() {
        Destroy(gameObject, lifetime);
    }
 
    void OnTriggerEnter(Collider other) {
        Destroy(other.gameObject);
        Destroy(gameObject);
    }
}
