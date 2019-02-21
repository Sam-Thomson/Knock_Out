﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boxer1Defence : MonoBehaviour {
	
	public Animator anim;

	// Use this for initialization
	void Start () {
		anim = this.gameObject.GetComponent<Animator> ();
	}
	// Update is called once per frame
	void Update () {
		if (Input.GetButtonDown("Controller1LeftStick")) {
			if (Input.GetButton ("Controller1LeftBumper")) {
				anim.SetBool ("LeftDodge", true);
			} else if (Input.GetButton("Controller1RightBumper")) {
				anim.SetBool ("RightDodge", true);
			} else {
				anim.SetBool ("BackDodge", true);
			}

		} else {
			anim.SetBool ("BackDodge", false);
			anim.SetBool ("LeftDodge", false);
			anim.SetBool ("RightDodge", false);
		}

		if (Input.GetButtonDown("Controller1RightStick")) {
			if (Input.GetButton ("Controller1LeftBumper")) {
				anim.SetBool ("LeftBlock", true);
			} else if (Input.GetButton("Controller1RightBumper")) {
				anim.SetBool ("RightBlock", true);
			} else {
				anim.SetBool ("CentreBlock", true);
			}

		} else {
			anim.SetBool ("RightBlock", false);
			anim.SetBool ("LeftBlock", false);
			anim.SetBool ("CentreBlock", false);
		}
	}
}

