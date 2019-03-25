using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boxer1Defence : MonoBehaviour {
	
	public Animator anim;

	public Boxer1Stamina stamina;

	// Use this for initialization
	void Start () {
		anim = this.gameObject.GetComponent<Animator> ();
		stamina = FindObjectOfType<Boxer1Stamina>();
	}
	// Update is called once per frame
	void Update () {
		if (Input.GetButtonDown("Controller1LeftStick")) {
			anim.SetBool ("BackDodge", true);
			stamina.dodgeStamina();

		} else {
			anim.SetBool ("BackDodge", false);
		}

		if (Input.GetButtonDown("Controller1RightStick")) {
			anim.SetBool ("CentreBlock", true);
			stamina.blockStamina();

		} else {
			anim.SetBool ("CentreBlock", false);
		}
	}
}

