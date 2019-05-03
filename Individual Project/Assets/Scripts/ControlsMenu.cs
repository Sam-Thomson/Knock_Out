using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.EventSystems;

public class ControlsMenu : MonoBehaviour {
	public EventSystem eventSystem;
	private GameObject selectedObject;

	void Start () {
		selectedObject = eventSystem.firstSelectedGameObject;
	}

	void Update () {
		if (eventSystem.currentSelectedGameObject != selectedObject) {
			if (eventSystem.currentSelectedGameObject == null) {
				eventSystem.SetSelectedGameObject (selectedObject);
			} else {
				selectedObject = eventSystem.currentSelectedGameObject;
			}
		}
	}

	public void BackToMenu () {
		SceneManager.LoadScene(0);
	}
}
