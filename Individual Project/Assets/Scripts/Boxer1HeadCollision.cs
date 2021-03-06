﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boxer1HeadCollision : MonoBehaviour {

	public Boxer1Health damage;
	public Boxer2Attacks callAttack;
	public int foundAttack;

	// Use this for initialization
	void Start () {
		damage = FindObjectOfType<Boxer1Health>();
	}


	public void OnTriggerEnter(Collider other){
		callAttack = FindObjectOfType<Boxer2Attacks>();
		foundAttack = callAttack.attack;
		if(other.gameObject.tag == "Boxer2Left")
		{
			if (foundAttack == 1) {
				damage.jabHit();
			}

			if (foundAttack == 3) {
				damage.hookHit();
			}

		} else if(other.gameObject.tag == "Boxer2Right")
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
