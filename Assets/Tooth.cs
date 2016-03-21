using UnityEngine;

public class Tooth : MonoBehaviour {
  public InfectTeeth skull;

  public void OnCollisionEnter(Collision collision) {
    GameObject otherGO = collision.collider.gameObject;
    if(otherGO.tag == "Sweets") {
      Rigidbody rigidbody = GetComponent<Rigidbody>();
      rigidbody.isKinematic = false;
      rigidbody.useGravity = true;

      // Propogate velocity.
      Rigidbody otherGORigidbody = otherGO.GetComponent<Rigidbody>();
      rigidbody.velocity = otherGORigidbody.velocity;
      rigidbody.angularVelocity = otherGORigidbody.angularVelocity;

      //
      Destroy(this, 2.0f);
      // notify teeth that we've been removed.
    }
  }
}
