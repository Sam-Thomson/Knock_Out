using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boxer2Attacks : MonoBehaviour {

	public Animator anim;
	public int attack = 0;

	float delayTimer = 5.0f;
	float currentDelayTimer;

	// Use this for initialization
	void Start () {
		anim = this.gameObject.GetComponent<Animator> ();
		currentDelayTimer = delayTimer;
	}

	// Update is called once per frame
	void Update () {
		if (Input.GetButton("Controller2AButton")) {
			anim.SetBool ("Jab", true);
			attack = 1;
		} else {
			anim.SetBool ("Jab", false);
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

		}	

		if (Input.GetButton("Controller2XButton")) {
			anim.SetBool ("Cross", true);
			attack = 2;
		} else {
			anim.SetBool ("Cross", false);
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
		}

		if (Input.GetButton("Controller2BButton")) {
			anim.SetBool ("BodyJab", true);
			attack = 5;
		} else {
			anim.SetBool ("BodyJab", false);
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
		}	

		if (Input.GetButton("Controller2YButton")) {
			anim.SetBool ("BodyCross", true);
			attack = 6;
		} else {
			anim.SetBool ("BodyCross", false);
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
		}	

		if (Mathf.Round (Input.GetAxisRaw ("Controller2Triggers")) > 0) {
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
