using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boxer1Movement : MonoBehaviour {

	private Vector3 startPosition;
	private Vector3 position;
	private Transform thisTransform;
	private float playerSpeed = 7.5f;
	private Rigidbody rb;

	public Animator anim;
	public Transform lockOnBoxer;


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
		direction.z = Input.GetAxis ("Controller1Horizontal");
		direction.x = Input.GetAxis ("Controller1Vertical");

		transform.LookAt(lockOnBoxer);

		float xMovement = (Input.GetAxis ("Controller1Horizontal") * playerSpeed) * Time.deltaTime;
		float zMovement = (Input.GetAxis ("Controller1Vertical")* playerSpeed) * Time.deltaTime;

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

		if(Input.GetKeyDown (KeyCode.Escape))
		{
			Application.Quit();
		}
			
	}

	void OnCollisionEnter(Collision other) 
	{
		if (other.gameObject.tag == "Rope") {
			rb.constraints = RigidbodyConstraints.FreezeRotation;
		}
	}

	void OnCollisionExit(Collision other) 
	{
		if (other.gameObject.tag == "Rope") {
			rb.constraints = RigidbodyConstraints.FreezePositionY | RigidbodyConstraints.FreezePositionZ | RigidbodyConstraints.FreezeRotation;
		}
	}
		
}

