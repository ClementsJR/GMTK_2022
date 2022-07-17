using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class LevelManager : MonoBehaviour {

	private float levelTimer = 0.0f;
	private bool runLevelTimer = true;

	[SerializeField]
	private TextMeshProUGUI timerLabel;
	[SerializeField]
	private GameObject levelEndScreen;
	[SerializeField]
	private TextMeshProUGUI scoreLabel;

	[SerializeField]
	private GroundRotator rotator;
	[SerializeField]
	private Goal goal;
	
    private void Update() {
		if (runLevelTimer)
			UpdateTimerLabel();
    }

	private void UpdateTimerLabel() {
		levelTimer += Time.deltaTime;
		timerLabel.text = levelTimer.ToString("F2");
	}

	public void NotifyGoalReached() {
		runLevelTimer = false;

		timerLabel.text = "";
		levelEndScreen.SetActive(true);
		scoreLabel.text = "Total Time\n" + levelTimer.ToString("F2");

		rotator.StopAcceptingEvents();
		goal.StopAcceptingEvents();
	}

	public void LoadScene(string nextScene) {
		SceneManager.LoadScene(nextScene);
	}
}
