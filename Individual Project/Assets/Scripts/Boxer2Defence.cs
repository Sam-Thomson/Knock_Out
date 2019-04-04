using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boxer2Defence : MonoBehaviour {
	public Animator anim;

	public Boxer2Stamina stamina;
	public float currentStamina;

	// Use this for initialization
	void Start () {
		anim = this.gameObject.GetComponent<Animator> ();
	}
	// Update is called once per frame
	void Update () {
		stamina = FindObjectOfType<Boxer2Stamina>();
		currentStamina = stamina.currentStamina;
		if (Input.GetButtonDown("Controller2LeftStick") && currentStamina >= 20f) {
			anim.SetBool ("BackDodge", true);
			stamina.dodgeStamina();

		} else {
			anim.SetBool ("BackDodge", false);
		}

		if (Input.GetButtonDown("Controller2RightStick") && currentStamina >= 5f) {
			anim.SetBool ("CentreBlock", true);
			stamina.blockStamina();

		} else {
			anim.SetBool ("CentreBlock", false);
		}
	}
}
