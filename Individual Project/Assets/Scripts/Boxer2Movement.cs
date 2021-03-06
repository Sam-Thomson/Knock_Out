﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boxer2Movement : MonoBehaviour {

	public Vector3 startPosition;
	private float playerSpeed = 7.5f;
	private Rigidbody rb;

	public Animator anim;
	public Transform lockOnBoxer;

	public Boxer2Health KnockedDown;
	public bool down;

	public Boxer1Health boxer1KnockedDown;
	public bool boxer1Down;

	// Use this for initialization
	void Start () {
		anim = this.gameObject.GetComponent<Animator> ();
		rb = GetComponent<Rigidbody>();
		startPosition = transform.position;
	}

	// Update is called once per frame
	void Update () {
		KnockedDown = FindObjectOfType<Boxer2Health>();
		down = KnockedDown.down;
		boxer1KnockedDown = FindObjectOfType<Boxer1Health>();
		boxer1Down = boxer1KnockedDown.down;

		if(down == false && boxer1Down == false){
		Vector3 direction = Vector3.zero;
		direction.z = Input.GetAxisRaw ("Controller2Horizontal");
		direction.x = Input.GetAxisRaw ("Controller2Vertical");

		transform.LookAt(lockOnBoxer);

		float xMovement = (Input.GetAxis ("Controller2Horizontal") * playerSpeed) * Time.deltaTime;
		float zMovement = (Input.GetAxis ("Controller2Vertical")* playerSpeed) * Time.deltaTime;

		Vector3 playerMovement = new Vector3 (xMovement, 0.0f, zMovement);
		transform.Translate (playerMovement * playerSpeed);
		

		if (direction.x > 0) {
			anim.SetBool ("MoveForward", true);
		} else {
			anim.SetBool ("MoveForward", false);
		}
		if (direction.x < 0) {
			anim.SetBool ("MoveBackward", true);
		} else {
			anim.SetBool ("MoveBackward", false);
		}
		if (direction.z > 0) {
			anim.SetBool ("MoveLeft", true);
		} else {
			anim.SetBool ("MoveLeft", false);
		}
		if (direction.z < 0) {
			anim.SetBool ("MoveRight", true);
		} else {
			anim.SetBool ("MoveRight", false);
		}
		}
	}

	public void resetPosition() {
		transform.position = startPosition;
	}

}
