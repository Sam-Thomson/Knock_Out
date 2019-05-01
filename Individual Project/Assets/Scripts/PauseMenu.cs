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

	void Update () {
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
	}

	void Pause () {
		pauseMenuUI.SetActive (true);
		Time.timeScale = 0;
		gamePaused = true;
		selectedObject = eventSystem.firstSelectedGameObject;
	}

	public void Quit(){
		Time.timeScale = 1;
		SceneManager.LoadScene(0);
	}
}
