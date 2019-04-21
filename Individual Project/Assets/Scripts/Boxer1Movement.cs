using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boxer1Movement : MonoBehaviour {

	public Vector3 startPosition;
	private float playerSpeed = 7.5f;
	private Rigidbody rb;

	public Animator anim;
	public Transform lockOnBoxer;

	public Boxer1Health KnockedDown;
	public bool down;

	public Boxer2Health boxer2KnockedDown;
	public bool boxer2Down;

	// Use this for initialization
	void Start () {
		anim = this.gameObject.GetComponent<Animator> ();
		rb = GetComponent<Rigidbody>();
		startPosition = transform.position;
	}
	
	// Update is called once per frame
	void Update () {
		KnockedDown = FindObjectOfType<Boxer1Health>();
		down = KnockedDown.down;
		boxer2KnockedDown = FindObjectOfType<Boxer2Health>();
		boxer2Down = boxer2KnockedDown.down;
		if (down == false && boxer2Down == false) {
			Vector3 direction = Vector3.zero;
			direction.z = Input.GetAxis ("Controller1Horizontal");
			direction.x = Input.GetAxis ("Controller1Vertical");

			transform.LookAt (lockOnBoxer);

			float xMovement = (Input.GetAxis ("Controller1Horizontal") * playerSpeed) * Time.deltaTime;
			float zMovement = (Input.GetAxis ("Controller1Vertical") * playerSpeed) * Time.deltaTime;

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
		}

		if(Input.GetKeyDown (KeyCode.Escape))
		{
			Application.Quit();
		}
			
	}

	public void resetPosition() {
		transform.position = startPosition;
	}

}

