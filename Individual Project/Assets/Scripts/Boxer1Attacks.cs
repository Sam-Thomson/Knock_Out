using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boxer1Attacks : MonoBehaviour {
	public Animator anim;
	public int attack = 0;

	float delayTimer = 5.0f;
	float currentDelayTimer;

	public Boxer1Stamina stamina;

	// Use this for initialization
	void Start () {
		anim = this.gameObject.GetComponent<Animator> ();
		currentDelayTimer = delayTimer;

		stamina = FindObjectOfType<Boxer1Stamina>();
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetButton("Controller1AButton")) {
			anim.SetBool ("Jab", true);
			attack = 1;
			if (Input.GetButtonDown ("Controller1AButton")) {
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

		if (Input.GetButton("Controller1XButton")) {
			anim.SetBool ("Cross", true);
			attack = 2;
			if (Input.GetButtonDown ("Controller1XButton")) {
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

		if (Input.GetButton("Controller1BButton")) {
			anim.SetBool ("BodyJab", true);
			attack = 5;
			if (Input.GetButtonDown ("Controller1BButton")) {
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

		if (Input.GetButton("Controller1YButton")) {
			anim.SetBool ("BodyCross", true);
			attack = 6;
			if (Input.GetButtonDown ("Controller1YButton")) {
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

		/*if (Mathf.Round (Input.GetAxisRaw ("Controller1Triggers")) > 0) {
			anim.SetBool ("LeftHook", true);
			attack = 3;
			stamina.hookStamina();		
		} else if (Mathf.Round (Input.GetAxisRaw ("Controller1Triggers")) < 0) {
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

		if (Input.GetButtonDown("Controller1LeftBumper")) {
			anim.SetBool ("LeftHook", true);
			attack = 3;
			if (Input.GetButtonDown ("Controller1LeftBumper")) {
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

		if (Input.GetButtonDown("Controller1RightBumper")) {
			anim.SetBool ("RightUppercut", true);
			attack = 4;
			if (Input.GetButtonDown ("Controller1RightBumper")) {
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
