using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spin : MonoBehaviour {

	[SerializeField]
	private float maxSpeed = 0.75f;
	[SerializeField]
	private float minSpeed = 0.25f;

	private float speed;
	private Vector3 rotationAxis;

	private void Start() {
		speed = Random.Range(minSpeed, maxSpeed);
		rotationAxis = Random.onUnitSphere;
	}

	private void FixedUpdate() {
		this.transform.Rotate(rotationAxis, speed);
	}
}
