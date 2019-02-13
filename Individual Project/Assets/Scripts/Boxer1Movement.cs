using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boxer1Movement : MonoBehaviour {

	private Vector3 startPosition;
	private Vector3 position;
	private Transform thisTransform;
	public Animator anim;


	// Use this for initialization
	void Start () {
		thisTransform = transform;
		position = thisTransform.position;
		startPosition = position;
		anim = this.gameObject.GetComponent<Animator> ();
	}
	
	// Update is called once per frame
	void Update () {
		Vector3 direction = Vector3.zero;
		direction.z = Input.GetAxis ("Controller1Horizontal");
		direction.x = Input.GetAxis ("Controller1Vertical");
		thisTransform.position = position + direction;
		position = thisTransform.position;

		if (direction.x < 0) {
			anim.SetBool ("MoveForward", true);
		} else {
			anim.SetBool ("MoveForward", false);
		}
		if (direction.x > 0) {
			anim.SetBool ("MoveBackward", true);
		} else {
			anim.SetBool ("MoveBackward", false);
		}
		if (direction.z < 0) {
			anim.SetBool ("MoveLeft", true);
		} else {
			anim.SetBool ("MoveLeft", false);
		}
		if (direction.z > 0) {
			anim.SetBool ("MoveRight", true);
		} else {
			anim.SetBool ("MoveRight", false);
		}
			
	}
}

