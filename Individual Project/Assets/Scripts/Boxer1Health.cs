using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Boxer1Health : MonoBehaviour {

	[SerializeField]
	Slider healthbar;

	float maxHealth = 100f;
	float currentHealth;

	void start(){

		healthbar.value = maxHealth;
		currentHealth = healthbar.value;
	}

	public void jabHit(){

		healthbar.value -= 5f;
		currentHealth = healthbar.value;
	}
}
