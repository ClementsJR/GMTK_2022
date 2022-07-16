using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Die : MonoBehaviour {

	[SerializeField]
	private MeshFilter meshFilter;

	private void Awake() {
		meshFilter.mesh = PersistentSettings.dieMesh;
	}
}
