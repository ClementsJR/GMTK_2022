using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallOutDetector : MonoBehaviour {

	[SerializeField]
	private Transform spawnPosition;
	[SerializeField]
	private Collider die;

	private void OnTriggerExit(Collider other) {
		if (other == die) {
			die.transform.position = spawnPosition.position;
		}
	}
}
