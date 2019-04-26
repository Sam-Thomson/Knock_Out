using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class KnockDown : MonoBehaviour {

	public Boxer1Health boxer1KnockedDown;
	public bool boxer1Down;

	public Boxer2Health boxer2KnockedDown;
	public bool boxer2Down;

	public Transform ProgressBar;
	[SerializeField]
	float progressAmount;
	[SerializeField]
	Image aButton;
	[SerializeField]
	Image aButtonProgress;
	[SerializeField]
	Image player1Wins;
	[SerializeField]
	Image player2Wins;

	float cTime;
	float sTime = 0f;

	int boxer1TotalKDs;
	int boxer2TotalKDs;

	public int boxer1RoundKDs;
	public int boxer2RoundKDs;

	[SerializeField]
	Text KDCText;

	void Start(){
		cTime = sTime;
	}

	// Update is called once per frame
	void Update () {
		boxer1KnockedDown = FindObjectOfType<Boxer1Health> ();
		boxer1Down = boxer1KnockedDown.down;
		boxer2KnockedDown = FindObjectOfType<Boxer2Health> ();
		boxer2Down = boxer2KnockedDown.down;
		if (boxer1Down == true) {
			aButton.enabled = true;
			aButtonProgress.enabled = true;
			KDCText.enabled = true;
			if(Input.GetButtonDown ("Controller1AButton") && cTime < 10) {
				if (boxer1TotalKDs >= 1) {
					progressAmount = progressAmount + (0.1f / (boxer1TotalKDs + 1));
				} else {
					progressAmount = progressAmount + 0.1f;
				}

			}
			if (progressAmount >= 1) {
				boxer1KnockedDown.boxer1Up ();
				aButton.enabled = false;
				aButtonProgress.enabled = false;
				progressAmount = 0;
				cTime = sTime;
				KDCText.enabled = false;
				boxer1TotalKDs++;
				boxer1RoundKDs++;
			}
			ProgressBar.GetComponent<Image> ().fillAmount = progressAmount;
			cTime += 1 * Time.deltaTime;
			KDCText.text = cTime.ToString("0");
			if (cTime >= 10) {
				player2Wins.enabled = true;
				if (Input.GetButtonDown ("Controller1AButton") || Input.GetButtonDown ("Controller2AButton")) {
					Debug.Log ("Player2 Wins");
				}
			}

		} else if (boxer2Down == true) {
			aButton.enabled = true;
			aButtonProgress.enabled = true;
			KDCText.enabled = true;
			if(Input.GetButtonDown ("Controller2AButton") && cTime < 10) {
				if (boxer2TotalKDs >= 1) {
					progressAmount = progressAmount + (0.1f / (boxer2TotalKDs + 1));
				} else {
					progressAmount = progressAmount + 0.1f;
				}
			}
			if (progressAmount >= 1) {
				boxer2KnockedDown.boxer2Up ();
				aButton.enabled = false;
				aButtonProgress.enabled = false;
				progressAmount = 0;
				cTime = sTime;
				KDCText.enabled = false;
				boxer2TotalKDs++;
				boxer2RoundKDs++;
			}
			ProgressBar.GetComponent<Image> ().fillAmount = progressAmount;
			cTime += 1 * Time.deltaTime;
			KDCText.text = cTime.ToString("0");
			if (cTime >= 10) {
				player1Wins.enabled = true;
				if (Input.GetButtonDown ("Controller1AButton") || Input.GetButtonDown ("Controller2AButton")) {
					Debug.Log ("Player1 Wins");
				}
			}
		}
	}
}
