using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boxer2Attacks : MonoBehaviour {

	public Animator anim;
	public int attack = 0;

	float delayTimer = 5.0f;
	float currentDelayTimer;
	public Boxer2Stamina stamina;

	// Use this for initialization
	void Start () {
		anim = this.gameObject.GetComponent<Animator> ();
		currentDelayTimer = delayTimer;

		stamina = FindObjectOfType<Boxer2Stamina>();
	}

	// Update is called once per frame
	void Update () {
		if (Input.GetButton("Controller2AButton")) {
			anim.SetBool ("Jab", true);
			attack = 1;
			if (Input.GetButtonDown ("Controller2AButton")) {
				stamina.jabStamina();
			}
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
			if (Input.GetButtonDown ("Controller2XButton")) {
				stamina.crossStamina();
			}
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
			if (Input.GetButtonDown ("Controller2BButton")) {
				stamina.bodyJabStamina();
			}
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
			if (Input.GetButtonDown ("Controller2YButton")) {
				stamina.bodyCrossStamina();
			}
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

		/*if (Mathf.Round (Input.GetAxisRaw ("Controller2Triggers")) > 0) {
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
		}*/



		if (Input.GetButton("Controller2LeftBumper")) {
			anim.SetBool ("LeftHook", true);
			attack = 3;
			if (Input.GetButtonDown ("Controller2LeftBumper")) {
				stamina.hookStamina();
			}
		} else {
			anim.SetBool ("LeftHook", false);
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

		if (Input.GetButton("Controller2RightBumper")) {
			anim.SetBool ("RightUppercut", true);
			attack = 4;
			if (Input.GetButtonDown ("Controller2RightBumper")) {
				stamina.uppercutStamina();
			}
		} else {
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
	}
}
