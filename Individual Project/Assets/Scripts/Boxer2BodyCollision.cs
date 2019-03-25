using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boxer2BodyCollision : MonoBehaviour {

	public Boxer2Health damage;
	public Boxer1Attacks callAttack;
	public int foundAttack;

	// Use this for initialization
	void Start () {
		damage = FindObjectOfType<Boxer2Health>();
	}


	public void OnTriggerEnter(Collider other){
		callAttack = FindObjectOfType<Boxer1Attacks>();
		foundAttack = callAttack.attack;
		if(other.gameObject.tag == "Boxer1Left")
		{
			if (foundAttack == 5) {
				damage.bodyJab();
			}

		} else if(other.gameObject.tag == "Boxer1Right")
		{
			if (foundAttack == 6) {
				damage.bodyCross();
			}
		}
	}
}
