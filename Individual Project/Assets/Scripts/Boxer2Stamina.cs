using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Boxer2Stamina : MonoBehaviour {

	[SerializeField]
	Slider staminabar;

	float maxStamina = 100f;
	public float currentStamina;

	float recoverSpeed = 10f;

	/*void Start () {
		staminabar.value = maxStamina;
		//currentStamina = staminabar.value;
	}*/

	public void jabStamina() {
		staminabar.value -= 10f;
		currentStamina = staminabar.value;
	}

	public void crossStamina() {
		staminabar.value -= 12f;
		currentStamina = staminabar.value;
	}

	public void hookStamina() {
		staminabar.value -= 15f;
		currentStamina = staminabar.value;
	}

	public void uppercutStamina() {
		staminabar.value -= 18f;
		currentStamina = staminabar.value;
	}

	public void bodyJabStamina() {
		staminabar.value -= 8f;
		currentStamina = staminabar.value;
	}

	public void bodyCrossStamina() {
		staminabar.value -= 10f;
		//currentStamina = staminabar.value;
	}

	public void blockStamina() {
		staminabar.value -= 5f;
		currentStamina = staminabar.value;
	}

	public void dodgeStamina() {
		staminabar.value -= 20f;
		currentStamina = staminabar.value;
	}

	void Update () {
		staminabar.value += recoverSpeed * Time.deltaTime;
		currentStamina = staminabar.value;
	}
}
