using UnityEngine;
using System.Collections;

public class SphereController : MonoBehaviour {
	float movement = 1.0f;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		Move ();
	}

	void Move ()
	{
		if (Input.GetKey (KeyCode.A)) {
			GetComponent<Rigidbody>().AddForce (Vector3.left * movement);
		}

		if (Input.GetKey (KeyCode.D)) {
			GetComponent<Rigidbody> ().AddForce (Vector3.right * movement);
		}

		if (Input.GetKey (KeyCode.W)) {
			GetComponent<Rigidbody> ().AddForce (Vector3.forward * movement);
		}

		if (Input.GetKey (KeyCode.D)) {
			GetComponent<Rigidbody> ().AddForce (Vector3.back * movement);
		}
	}
}
