using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Boxer1Attacks : MonoBehaviour {
	public Animator anim;
	public int attack = 0;

	float delayTimer = 5f;
	public float currentDelayTimer;

	public Boxer1Stamina stamina;
	public float currentStamina;

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

	//int downCount = 0;

	// Use this for initialization
	void Start () {
		anim = this.gameObject.GetComponent<Animator> ();
		currentDelayTimer = delayTimer;
	}
	
	// Update is called once per frame
	void Update () {
		stamina = FindObjectOfType<Boxer1Stamina> ();
		currentStamina = stamina.currentStamina;
		boxer1KnockedDown = FindObjectOfType<Boxer1Health> ();
		boxer1Down = boxer1KnockedDown.down;
		boxer2KnockedDown = FindObjectOfType<Boxer2Health> ();
		boxer2Down = boxer2KnockedDown.down;

		if (boxer1Down == false && boxer2Down == false) {
			if (Input.GetButtonDown ("Controller1AButton") && currentStamina >= 10f) {
				anim.SetBool ("Jab", true);
				attack = 1;
				currentDelayTimer = delayTimer;
				stamina.jabStamina ();
			} else {
				anim.SetBool ("Jab", false);
				if (currentDelayTimer > 0) {
					currentDelayTimer -= Time.deltaTime;
					if (currentDelayTimer <= 0) {
						currentDelayTimer = 0;
						if (currentDelayTimer == 0) {
							attack = 0;
						}
					}
				}

			}	

			if (Input.GetButtonDown ("Controller1XButton") && currentStamina >= 12f) {
				anim.SetBool ("Cross", true);
				attack = 2;
				currentDelayTimer = delayTimer;
				stamina.crossStamina ();
			} else {
				anim.SetBool ("Cross", false);
				if (currentDelayTimer > 0) {
					currentDelayTimer -= Time.deltaTime;
					if (currentDelayTimer <= 0) {
						currentDelayTimer = 0;
						if (currentDelayTimer == 0) {
							attack = 0;
						}
					}
				}
				
			}	

			if (Input.GetButtonDown ("Controller1BButton") && currentStamina >= 8f) {
				anim.SetBool ("BodyJab", true);
				attack = 5;
				currentDelayTimer = delayTimer;
				stamina.bodyJabStamina ();
			} else {
				anim.SetBool ("BodyJab", false);
				if (currentDelayTimer > 0) {
					currentDelayTimer -= Time.deltaTime;
					if (currentDelayTimer <= 0) {
						currentDelayTimer = 0;
						if (currentDelayTimer == 0) {
							attack = 0;
						}
					}
				}
			}	

			if (Input.GetButtonDown ("Controller1YButton") && currentStamina >= 10f) {
				anim.SetBool ("BodyCross", true);
				attack = 6;
				currentDelayTimer = delayTimer;
				stamina.bodyCrossStamina ();
			} else {
				anim.SetBool ("BodyCross", false);
				if (currentDelayTimer > 0) {
					currentDelayTimer -= Time.deltaTime;
					if (currentDelayTimer <= 0) {
						currentDelayTimer = 0;
						if (currentDelayTimer == 0) {
							attack = 0;
						}
					}
				}
			}	

			/*if (Mathf.Round (Input.GetAxisRaw ("Controller1Triggers")) > 0) {
			anim.SetBool ("LeftHook", true);
			attack = 3;
			stamina.hookStamina();		
		} else if (Mathf.Round (Input.GetAxisRaw ("Controller1Triggers")) < 0) {
			anim.SetBool ("RightUppercut", true);
			attack = 4;
		} else {
			anim.SetBool ("LeftHook", false);
			anim.SetBool ("RightUppercut", false);
			if (currentDelayTimer > 0) 
			{
				currentDelayTimer -= Time.deltaTime;
				if (currentDelayTimer <= 0) 
				{
					currentDelayTimer = 0;
					if(currentDelayTimer == 0)
					{
						attack = 0;
						currentDelayTimer = delayTimer;
					}
				}
			}
		}*/

			if (Input.GetButtonDown ("Controller1LeftBumper") && currentStamina >= 15f) {
				anim.SetBool ("LeftHook", true);
				attack = 3;
				currentDelayTimer = delayTimer;
				stamina.hookStamina ();
			} else {
				anim.SetBool ("LeftHook", false);
				if (currentDelayTimer > 0) {
					currentDelayTimer -= Time.deltaTime;
					if (currentDelayTimer <= 0) {
						currentDelayTimer = 0;
						if (currentDelayTimer == 0) {
							attack = 0;
						}
					}
				}
			}	

			if (Input.GetButtonDown ("Controller1RightBumper") && currentStamina >= 18f) {
				anim.SetBool ("RightUppercut", true);
				attack = 4;
				currentDelayTimer = delayTimer;
				stamina.uppercutStamina ();
			} else {
				anim.SetBool ("RightUppercut", false);
				if (currentDelayTimer > 0) {
					currentDelayTimer -= Time.deltaTime;
					if (currentDelayTimer <= 0) {
						currentDelayTimer = 0;
						if (currentDelayTimer == 0) {
							attack = 0;
						}
					}
				}
			}

		} /*else if (boxer1Down == true) {
			aButton.enabled = true;
			aButtonProgress.enabled = true;
			if(Input.GetButtonDown ("Controller1AButton")) {
				//downCount++;
				progressAmount = progressAmount + 0.1f;
				//ProgressBar.GetComponent<Image> ().fillAmount = progressAmount;
			}
			if (progressAmount >= 1) {
				boxer1KnockedDown.boxer1Up ();
				aButton.enabled = false;
				aButtonProgress.enabled = false;
				progressAmount = 0;
			}
			ProgressBar.GetComponent<Image> ().fillAmount = progressAmount;
		}*/
			
	}
}
