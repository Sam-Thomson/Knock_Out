using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boxer2Defence : MonoBehaviour {
	public Animator anim;

	public Boxer2Stamina stamina;
	public float currentStamina;

	public Boxer1Health boxer1KnockedDown;
	public bool boxer1Down;

	public Boxer2Health boxer2KnockedDown;
	public bool boxer2Down;

	public Boxer1Attacks boxer1Attacks;
	public int attackType;

	public PointCounter pointIncrease;

	// Use this for initialization
	void Start () {
		anim = this.gameObject.GetComponent<Animator> ();
	}
	// Update is called once per frame
	void Update () {
		stamina = FindObjectOfType<Boxer2Stamina> ();
		currentStamina = stamina.currentStamina;
		boxer1KnockedDown = FindObjectOfType<Boxer1Health> ();
		boxer1Down = boxer1KnockedDown.down;
		boxer2KnockedDown = FindObjectOfType<Boxer2Health> ();
		boxer2Down = boxer2KnockedDown.down;
		boxer1Attacks = FindObjectOfType<Boxer1Attacks> ();
		attackType = boxer1Attacks.attack;
		pointIncrease = FindObjectOfType<PointCounter> ();

		if (boxer1Down == false && boxer2Down == false) {
			if (Input.GetButtonDown ("Controller2LeftStick") && currentStamina >= 20f) {
				anim.SetBool ("BackDodge", true);
				stamina.dodgeStamina ();
				if (attackType != 0) {
					pointIncrease.boxer2DefencePoints ();
				}

			} else {
				anim.SetBool ("BackDodge", false);
			}

			if (Input.GetButtonDown ("Controller2RightStick") && currentStamina >= 5f) {
				anim.SetBool ("CentreBlock", true);
				stamina.blockStamina ();
				if (attackType != 0) {
					pointIncrease.boxer2DefencePoints ();
				}

			} else {
				anim.SetBool ("CentreBlock", false);
			}
		}
	}
}
