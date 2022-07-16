using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Die : MonoBehaviour {

	[SerializeField]
	private Mesh defaultMesh;
	[SerializeField]
	private MeshFilter meshFilter;
	[SerializeField]
	private MeshCollider meshCollider;

	private void Awake() {
		//Mesh dieMesh = PersistentSettings.useDefaultMesh ? defaultMesh : PersistentSettings.dieMesh;

		//meshFilter.mesh = dieMesh;
		//meshCollider.sharedMesh = dieMesh;
	}
}
