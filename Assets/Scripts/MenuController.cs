using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuController : MonoBehaviour {

	public GameObject menuScreen;
	public GameObject dieSelectScreen;
	public GameObject instructionsScreen;
	public GameObject creditsScreen;

	public GameObject spaceDice;
	public GameObject selectDice;

	public void StartBtnClicked() {
		menuScreen.SetActive(false);
		dieSelectScreen.SetActive(true);

		spaceDice.SetActive(false);
		selectDice.SetActive(true);
	}

	public void SelectDie(GameObject diePrefab) {
		PersistentSettings.diePrefab = diePrefab;
		PersistentSettings.useDefaultDie = false;
		SceneManager.LoadScene("Level 1");
	}

	public void InstructionsBtnClicked() {
		menuScreen.SetActive(false);
		instructionsScreen.SetActive(true);
	}

	public void CreditsBtnClicked() {
		menuScreen.SetActive(false);
		creditsScreen.SetActive(true);
	}

	public void BackBtnClicked() {
		menuScreen.SetActive(true);
		dieSelectScreen.SetActive(false);
		instructionsScreen.SetActive(false);
		creditsScreen.SetActive(false);

		spaceDice.SetActive(true);
		selectDice.SetActive(false);
	}
}
