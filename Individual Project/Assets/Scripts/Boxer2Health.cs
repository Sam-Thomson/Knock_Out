using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Boxer2Health : MonoBehaviour {

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

	public void crossHit(){
		healthbar.value -= 7.5f;
		currentHealth = healthbar.value;
	}

	public void hookHit(){
		healthbar.value -= 12f;
		currentHealth = healthbar.value;
	}

	public void uppercutHit(){
		healthbar.value -= 15f;
		currentHealth = healthbar.value;
	}

	public void bodyJab(){
		healthbar.value -= 4f;
		currentHealth = healthbar.value;
	}

	public void bodyCross(){
		healthbar.value -= 6.5f;
		currentHealth = healthbar.value;
	}
}
