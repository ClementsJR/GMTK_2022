using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FloorSpinner : MonoBehaviour {

	[SerializeField]
	private float speed = 0.5f;
	
    private void Update() {
		this.transform.Rotate(Vector3.up, speed);
    }
}
