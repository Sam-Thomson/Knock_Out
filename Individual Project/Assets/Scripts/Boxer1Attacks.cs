using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boxer1Attacks : MonoBehaviour {
	public Animator anim;
	// Use this for initialization
	void Start () {
		anim = this.gameObject.GetComponent<Animator> ();

	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetButtonDown("Controller1AButton")) {
			anim.SetBool ("Jab", true);
		} else {
			anim.SetBool ("Jab", false);
		}	

		if (Input.GetButtonDown("Controller1XButton")) {
			anim.SetBool ("Cross", true);
		} else {
			anim.SetBool ("Cross", false);
		}	

		/*if (Input.GetButtonDown("Controller1BButton")) {
			anim.SetBool ("Hook", true);
		} else {
			anim.SetBool ("Hook", false);
		}	

		if (Input.GetButtonDown("Controller1YButton")) {
			anim.SetBool ("Uppercut", true);
		} else {
			anim.SetBool ("Uppercut", false);
		}	*/

		if (Mathf.Round (Input.GetAxisRaw ("Controller1Triggers")) < 0) {
			anim.SetBool ("LeftUppercut", true);
		} else if (Mathf.Round (Input.GetAxisRaw ("Controller1Triggers")) > 0) {
			anim.SetBool ("RightUppercut", true);
		} else {
			anim.SetBool ("LeftUppercut", false);
			anim.SetBool ("RightUppercut", false);

		}
	}
}
