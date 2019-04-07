using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boxer1Defence : MonoBehaviour {
	
	public Animator anim;

	public Boxer1Stamina stamina;
	public float currentStamina;

	public Boxer1Health boxer1KnockedDown;
	public bool boxer1Down;

	public Boxer2Health boxer2KnockedDown;
	public bool boxer2Down;

	// Use this for initialization
	void Start () {
		anim = this.gameObject.GetComponent<Animator> ();
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
			if (Input.GetButtonDown ("Controller1LeftStick") && currentStamina >= 20f) {
				anim.SetBool ("BackDodge", true);
				stamina.dodgeStamina ();

			} else {
				anim.SetBool ("BackDodge", false);
			}

			if (Input.GetButtonDown ("Controller1RightStick") && currentStamina >= 5f) {
				anim.SetBool ("CentreBlock", true);
				stamina.blockStamina ();

			} else {
				anim.SetBool ("CentreBlock", false);
			}
		}
	}
}

