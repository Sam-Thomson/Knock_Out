using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boxer2Movement : MonoBehaviour {

	private Vector3 startPosition;
	private Vector3 position;
	private Transform thisTransform;
	public Animator anim;
	private float playerSpeed = 7.5f;
	private Rigidbody rb;

	// Use this for initialization
	void Start () {
		thisTransform = transform;
		position = thisTransform.position;
		startPosition = position;
		anim = this.gameObject.GetComponent<Animator> ();
		rb = GetComponent<Rigidbody>();
	}

	// Update is called once per frame
	void Update () {
		Vector3 direction = Vector3.zero;
		direction.z = Input.GetAxisRaw ("Controller2Horizontal");
		direction.x = Input.GetAxisRaw ("Controller2Vertical");

		float xMovement = (Input.GetAxis ("Controller2Horizontal") * playerSpeed) * Time.deltaTime;
		float zMovement = (Input.GetAxis ("Controller2Vertical")* playerSpeed) * Time.deltaTime;

		Vector3 playerMovement = new Vector3 (xMovement, 0.0f, zMovement);
		transform.Translate (playerMovement * playerSpeed);
		//thisTransform.position = position + direction;
		//position = thisTransform.position;

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
