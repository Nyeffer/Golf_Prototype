using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hit : MonoBehaviour {

	// Public Variable
	public float force = 100;
	public Rigidbody rb;

	public void Shoot() {
		rb.AddForce(rb.gameObject.transform.forward * force, ForceMode.Impulse);
	}
}
