using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundRotator : MonoBehaviour {

	[SerializeField]
	private DieSpawner dieSpawner;
	private Transform die;

	[SerializeField]
	private Vector3 pidGains = Vector3.one;

	[SerializeField]
	private float maxTilt = 15.0f;
	private float pitch = 0.0f;
	private float roll = 0.0f;

	private PIDController pitchPID;
	private PIDController rollPID;

	private void Start() {
		die = dieSpawner.die.transform;

		pitchPID = new PIDController(pidGains);
		rollPID = new PIDController(pidGains);
	}
	
	private void FixedUpdate() {
		float pitchInput = LevelManager.inPlay ? Input.GetAxis("Vertical") : 0.0f;
		float rollInput = LevelManager.inPlay ? -Input.GetAxis("Horizontal") : 0.0f;

		float pitchTarget = maxTilt * pitchInput;
		float rollTarget = maxTilt * rollInput;

		pitch += pitchPID.LoopFeedback(pitchTarget, pitch);
		roll += rollPID.LoopFeedback(rollTarget, roll);
		
		this.transform.localEulerAngles = Vector3.zero;
		this.transform.position = Vector3.zero;
		this.transform.RotateAround(die.position, Vector3.right, pitch);
		this.transform.RotateAround(die.position, Vector3.forward, roll);
	}
}
