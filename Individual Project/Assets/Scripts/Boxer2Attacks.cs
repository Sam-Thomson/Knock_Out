using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boxer2Attacks : MonoBehaviour {

	public Animator anim;
	public int attack = 0;

	float delayTimer = 5.0f;
	float currentDelayTimer;

	public Boxer2Stamina stamina;
	public float currentStamina;

	public Boxer1Health boxer1KnockedDown;
	public bool boxer1Down;

	public Boxer2Health boxer2KnockedDown;
	public bool boxer2Down;

	int downCount = 0;

	// Use this for initialization
	void Start () {
		anim = this.gameObject.GetComponent<Animator> ();
		currentDelayTimer = delayTimer;
	}

	// Update is called once per frame
	void Update () {
		stamina = FindObjectOfType<Boxer2Stamina> ();
		currentStamina = stamina.currentStamina;
		boxer1KnockedDown = FindObjectOfType<Boxer1Health> ();
		boxer1Down = boxer1KnockedDown.down;
		boxer2KnockedDown = FindObjectOfType<Boxer2Health> ();
		boxer2Down = boxer2KnockedDown.down;

		if (boxer1Down == false && boxer2Down == false && PauseMenu.gamePaused == false) {
			if (Input.GetButtonDown ("Controller2AButton") && currentStamina >= 10f) {
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

			if (Input.GetButtonDown ("Controller2XButton") && currentStamina >= 12f) {
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

			if (Input.GetButtonDown ("Controller2BButton") && currentStamina >= 8f) {
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

			if (Input.GetButtonDown ("Controller2YButton") && currentStamina >= 10f) {
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

			/*if (Mathf.Round (Input.GetAxisRaw ("Controller2Triggers")) > 0) {
			anim.SetBool ("LeftHook", true);
			attack = 3;
		} else if (Mathf.Round (Input.GetAxisRaw ("Controller2Triggers")) < 0) {
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



			if (Input.GetButtonDown ("Controller2LeftBumper") && currentStamina >= 15f) {
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

			if (Input.GetButtonDown ("Controller2RightBumper") && currentStamina >= 18f) {
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
		} 
	}
}
