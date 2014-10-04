using UnityEngine;
using System.Collections;

public class RocketController : MonoBehaviour {

	float Vx, Vy, Vz;
	void Start () {
		Vx = Vy = Vz = 0.0f;
	}

	void FixedUpdate () {
		rigidbody.AddForce (50f, 0.0f, 0.0f);
	}
	
}
