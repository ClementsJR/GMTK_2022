using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour {

	[SerializeField]
	private Transform die;

	[SerializeField]
	private Vector3 targetFollow = Vector3.one;

	[SerializeField]
	private Vector3 pidGains = Vector3.one;
	private PIDController xPID;
	private PIDController yPID;
	private PIDController zPID;

	private void Start() {
		xPID = new PIDController(pidGains);
		yPID = new PIDController(pidGains);
		zPID = new PIDController(pidGains);
	}

	private void FixedUpdate() {
		Vector3 targetPosition = die.position + targetFollow;

		float deltaX = xPID.LoopFeedback(targetPosition.x, transform.position.x);
		float deltaY = yPID.LoopFeedback(targetPosition.y, transform.position.y);
		float deltaZ = zPID.LoopFeedback(targetPosition.z, transform.position.z);

		Vector3 deltaPosition = new Vector3(deltaX, deltaY, deltaZ);
		transform.position = transform.position + deltaPosition;
	}
}
