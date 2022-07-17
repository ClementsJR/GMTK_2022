using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DieSpawner : MonoBehaviour {

	[SerializeField]
	private Transform spawnPoint;
	[SerializeField]
	private GameObject defaultPrefab;

	public GameObject die;
	public Collider dieCollider;

    private void Awake() {
		GameObject diePrefab = PersistentSettings.useDefaultDie ? defaultPrefab : PersistentSettings.diePrefab;

		die = Instantiate(diePrefab, spawnPoint.position, Quaternion.identity);
		dieCollider = die.GetComponent<Collider>();
    }
}
