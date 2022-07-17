using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallOutDetector : MonoBehaviour {

	[SerializeField]
	private Transform spawnPosition;
	[SerializeField]
	private DieSpawner dieSpawner;

	private void OnTriggerExit(Collider other) {
		if (other == dieSpawner.dieCollider) {
			dieSpawner.die.transform.position = spawnPosition.position;
		}
	}
}
