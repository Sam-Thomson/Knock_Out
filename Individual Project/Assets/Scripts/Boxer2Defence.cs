using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boxer2Defence : MonoBehaviour {
	public Animator anim;

	public Boxer2Stamina stamina;

	// Use this for initialization
	void Start () {
		anim = this.gameObject.GetComponent<Animator> ();
		stamina = FindObjectOfType<Boxer2Stamina>();
	}
	// Update is called once per frame
	void Update () {
		if (Input.GetButtonDown("Controller2LeftStick")) {
			anim.SetBool ("BackDodge", true);
			stamina.dodgeStamina();

		} else {
			anim.SetBool ("BackDodge", false);
		}

		if (Input.GetButtonDown("Controller2RightStick")) {
			anim.SetBool ("CentreBlock", true);
			stamina.blockStamina();

		} else {
			anim.SetBool ("CentreBlock", false);
		}
	}
}
