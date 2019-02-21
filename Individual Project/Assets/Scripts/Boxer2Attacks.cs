using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boxer2Attacks : MonoBehaviour {

	public Animator anim;
	// Use this for initialization
	void Start () {
		anim = this.gameObject.GetComponent<Animator> ();
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetButtonDown("Controller2AButton")) {
			anim.SetBool ("Jab", true);
		} else {
			anim.SetBool ("Jab", false);
		}	

		if (Input.GetButtonDown("Controller2XButton")) {
			anim.SetBool ("Cross", true);
		} else {
			anim.SetBool ("Cross", false);
		}

		if (Input.GetButtonDown("Controller2BButton")) {
			anim.SetBool ("BodyJab", true);
		} else {
			anim.SetBool ("BodyJab", false);
		}	

		if (Input.GetButtonDown("Controller2YButton")) {
			anim.SetBool ("BodyCross", true);
		} else {
			anim.SetBool ("BodyCross", false);
		}	

		if (Mathf.Round (Input.GetAxisRaw ("Controller2Triggers")) > 0) {
			anim.SetBool ("LeftHook", true);
		} else if (Mathf.Round (Input.GetAxisRaw ("Controller2Triggers")) < 0) {
			anim.SetBool ("RightUppercut", true);
		} else {
			anim.SetBool ("LeftHook", false);
			anim.SetBool ("RightUppercut", false);
		}

		/*if (Input.GetButtonDown("Controller2LeftBumper")) {
			anim.SetBool ("LeftHook", true);
		} else {
			anim.SetBool ("LeftHook", false);
		}	

		if (Input.GetButtonDown("Controller2RightBumper")) {
			anim.SetBool ("RightHook", true);
		} else {
			anim.SetBool ("RightHook", false);
		}	*/
	}
}
