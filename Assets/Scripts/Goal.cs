using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Goal : MonoBehaviour {
	[SerializeField]
	private LevelManager levelManager;
	[SerializeField]
	private DieSpawner dieSpawner;

	private bool acceptEvents = true;

	private void OnTriggerEnter(Collider other) {
		if (acceptEvents && other == dieSpawner.dieCollider)
			levelManager.NotifyGoalReached();
	}

	public void StopAcceptingEvents() {
		acceptEvents = false;
	}
}
