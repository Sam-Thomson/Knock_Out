using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.EventSystems;

public class PauseMenu : MonoBehaviour {

	public static bool gamePaused = false;
	public GameObject pauseMenuUI;

	public EventSystem eventSystem;
	private GameObject selectedObject;

	AudioSource crowd;

	void Update () {
		crowd = FindObjectOfType<AudioSource>();
		if (Input.GetButtonDown ("PauseMenu")) {
			if (gamePaused == true) {
				Resume();
			} else {
				Pause();
			}
		}
		if (eventSystem.currentSelectedGameObject != selectedObject) {
			if (eventSystem.currentSelectedGameObject == null) {
				eventSystem.SetSelectedGameObject (selectedObject);
			} else {
				selectedObject = eventSystem.currentSelectedGameObject;
			}
		}
	}

	public void Resume () {
		pauseMenuUI.SetActive (false);
		Time.timeScale = 1;
		gamePaused = false;
		crowd.Play();
	}

	void Pause () {
		pauseMenuUI.SetActive (true);
		Time.timeScale = 0;
		gamePaused = true;
		selectedObject = eventSystem.firstSelectedGameObject;
		crowd.Pause();
	}

	public void Quit(){
		Time.timeScale = 1;
		SceneManager.LoadScene(0);
	}
}
