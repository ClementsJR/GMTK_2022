using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PIDController {

	private Vector3 gain;

	private float lastError = 0.0f;
	private float lastValue = 0.0f;

	private bool derivativeInitialized = false;

    public PIDController(Vector3 gain) {
		this.gain = gain;
	}

	public float LoopFeedback(float targetValue, float currentValue) {
		float error = targetValue - currentValue;
		float deltaError = (error - lastError) / Time.fixedDeltaTime;
		lastError = error;
		float deltaValue = (currentValue - lastValue) / Time.fixedDeltaTime;
		lastValue = currentValue;

		float P = gain.x * error;
		float I = 0.0f;
		float D = derivativeInitialized ? gain.z * deltaValue : 0.0f;

		return P + I + D;
	}

	
}
