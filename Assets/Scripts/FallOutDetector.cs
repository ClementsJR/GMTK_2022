using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallOutDetector : MonoBehaviour {

	[SerializeField]
	private Transform spawnPosition;
	[SerializeField]
	private DieSpawner dieSpawner;

	private Transform die;
	private Rigidbody dieBody;

	private void Start() {
		die = dieSpawner.die.transform;
		dieBody = die.GetComponent<Rigidbody>();
	}

	private void OnTriggerExit(Collider other) {
		if (other == dieSpawner.dieCollider) {
			die.position = spawnPosition.position;
			dieBody.angularVelocity = Vector3.zero;
			dieBody.velocity = Vector3.zero;
		}
	}
}
