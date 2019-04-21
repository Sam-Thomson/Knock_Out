using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Rounds : MonoBehaviour {

	float roundTime = 120f;
	int roundNumber = 1;

	public Text roundTimer;
	public Text roundNumberText;
	public static float timer;

	public Boxer1Movement boxer1Position;
	public Boxer2Movement boxer2Position;

	void Start() {
		boxer1Position = FindObjectOfType<Boxer1Movement>();
		boxer2Position = FindObjectOfType<Boxer2Movement>();
	}
		
	private void Update()
	{
		roundTime -= Time.deltaTime;
		int minutes = Mathf.FloorToInt(roundTime / 60f);
		int seconds = Mathf.RoundToInt(roundTime % 60f);

		if (seconds == 60)
		{
			seconds = 0;
			minutes += 1;
		}

		roundTimer.text = minutes.ToString("0") + ":" + seconds.ToString("00");
		roundNumberText.text = roundNumber.ToString ("0");

		if (roundTimer.text == "0:00") 
		{
			roundTime = 120f;
			roundNumber++;
			boxer1Position.resetPosition();
			boxer2Position.resetPosition();
		}
	}
}
