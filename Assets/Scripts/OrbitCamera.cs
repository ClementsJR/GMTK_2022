using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OrbitCamera : MonoBehaviour {

	[SerializeField]
	private Transform target;
	[SerializeField, Range(5f, 65f)]
	private float distance = 35f;

	private void LateUpdate() {
		Vector3 lookDirection =this.transform.forward;
		this.transform.localPosition = target.position - lookDirection * distance;
	}
}
