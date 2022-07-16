using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Goal : MonoBehaviour {

	[SerializeField]
	private string nextLevel;
	[SerializeField]
	private Collider die;

	private void OnTriggerEnter(Collider other) {
		if(other == die)
			SceneManager.LoadScene(nextLevel);
	}
}
