using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DieRotator : MonoBehaviour {

	[SerializeField]
	private Rigidbody rigidBody;
	[SerializeField]
	private float force = 0.25f;

	private void FixedUpdate() {
		float deltaPitch = Input.GetAxis("Vertical") * force;
		float deltaRoll = -Input.GetAxis("Horizontal") * force;

		Vector3 rotation = new Vector3(deltaPitch, 0.0f, deltaRoll);

		if (LevelManager.inPlay)
			rigidBody.AddTorque(rotation);
	}
}
