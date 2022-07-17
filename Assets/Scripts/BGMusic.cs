using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BGMusic : MonoBehaviour {

	[SerializeField]
	private AudioClip menuMusic;
	[SerializeField]
	private string menuScene;

	[SerializeField]
	private AudioClip world1Music;
	[SerializeField]
	private string[] world1Scenes;

	[SerializeField]
	private AudioClip world2Music;
	[SerializeField]
	private string[] world2Scenes;

	[SerializeField]
	private AudioClip world3Music;
	[SerializeField]
	private string[] world3Scenes;

	[SerializeField]
	private AudioClip world4Music;
	[SerializeField]
	private string[] world4Scenes;

	[SerializeField]
	private AudioSource musicPlayer;

	private AudioClip currentClip = null;

	private void Start() {
		DontDestroyOnLoad(this.gameObject);

		SceneManager.sceneLoaded += OnSceneLoaded;
		ChangeClip(menuMusic);
    }

	private void OnSceneLoaded(Scene scene, LoadSceneMode mode) {
		string sceneName = scene.name;

		if (currentClip != menuMusic && sceneName == menuScene) {
			//ChangeClip(menuMusic);
			//return;

			DestroyImmediate(this.gameObject);
		}

		if (currentClip != world1Music && IsInSceneList(sceneName, world1Scenes)) {
			ChangeClip(world1Music);
			return;
		}

		if (currentClip != world2Music && IsInSceneList(sceneName, world2Scenes)) {
			ChangeClip(world2Music);
			return;
		}

		if (currentClip != world3Music && IsInSceneList(sceneName, world3Scenes)) {
			ChangeClip(world3Music);
			return;
		}

		if (currentClip != world4Music && IsInSceneList(sceneName, world4Scenes)) {
			ChangeClip(world4Music);
			return;
		}
	}

	private bool IsInSceneList(string sceneName, string[] list) {
		foreach (string name in list) {
			if (sceneName == name)
				return true;
		}

		return false;
	}

	private void ChangeClip(AudioClip clip) {
		currentClip = clip;
		musicPlayer.clip = clip;
		musicPlayer.Play();
	}
}
