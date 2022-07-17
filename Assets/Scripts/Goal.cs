using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Goal : MonoBehaviour {
	[SerializeField]
	private LevelManager levelManager;
	[SerializeField]
	private DieSpawner dieSpawner;

	private void OnTriggerEnter(Collider other) {
		if (LevelManager.inPlay && other == dieSpawner.dieCollider)
			levelManager.NotifyGoalReached();
	}
}
