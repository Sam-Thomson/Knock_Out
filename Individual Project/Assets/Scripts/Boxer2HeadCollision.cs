using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boxer2HeadCollision : MonoBehaviour {

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
			if (foundAttack == 1) {
				damage.jabHit();
			}

			if (foundAttack == 3) {
				damage.hookHit();
			}

		} else if(other.gameObject.tag == "Boxer1Right")
		{
			if (foundAttack == 2) {
				damage.crossHit();
			}

			if (foundAttack == 4) {
				damage.uppercutHit();
			}

		}
	}
}
