using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Goal : MonoBehaviour {

	[SerializeField]
	private string nextLevel;
	[SerializeField]
	private DieSpawner dieSpawner;

	private void OnTriggerEnter(Collider other) {
		if(other == dieSpawner.dieCollider)
			SceneManager.LoadScene(nextLevel);
	}
}
