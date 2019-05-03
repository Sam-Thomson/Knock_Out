using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.EventSystems;

public class MainMenu : MonoBehaviour {
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
	public void Play () {
		SceneManager.LoadScene(1);
	}

	public void Controls () {
		SceneManager.LoadScene(2);
	}

	public void Quit () {
		Application.Quit();
	}


}
