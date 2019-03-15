using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boxer1HeadCollision : MonoBehaviour {

	public Boxer1Health i;
	// Use this for initialization
	void Start () {
		i = FindObjectOfType<Boxer1Health>();
	}


	void OnTriggerEnter(Collider other){
		if(other.gameObject.tag == "Boxer2Left")
		{
			i.jabHit();
		}
	}
}
