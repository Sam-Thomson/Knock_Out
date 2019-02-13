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
	}
}
