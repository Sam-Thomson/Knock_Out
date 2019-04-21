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

	float cTime;
	float sTime = 0f;

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
			if(Input.GetButtonDown ("Controller1AButton")) {
				progressAmount = progressAmount + 0.1f;
				//ProgressBar.GetComponent<Image> ().fillAmount = progressAmount;
			}
			if (progressAmount >= 1) {
				boxer1KnockedDown.boxer1Up ();
				aButton.enabled = false;
				aButtonProgress.enabled = false;
				progressAmount = 0;
				cTime = sTime;
				KDCText.enabled = false;
			}
			ProgressBar.GetComponent<Image> ().fillAmount = progressAmount;
			cTime += 1 * Time.deltaTime;
			KDCText.text = cTime.ToString("0");

		} else if (boxer2Down == true) {
			aButton.enabled = true;
			aButtonProgress.enabled = true;
			KDCText.enabled = true;
			if(Input.GetButtonDown ("Controller2AButton")) {
				progressAmount = progressAmount + 0.1f;
			}
			if (progressAmount >= 1) {
				boxer2KnockedDown.boxer2Up ();
				aButton.enabled = false;
				aButtonProgress.enabled = false;
				progressAmount = 0;
				cTime = sTime;
				KDCText.enabled = false;
			}
			ProgressBar.GetComponent<Image> ().fillAmount = progressAmount;
			cTime += 1 * Time.deltaTime;
			KDCText.text = cTime.ToString("0");
		}
	}
}
