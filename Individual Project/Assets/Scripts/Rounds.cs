﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Rounds : MonoBehaviour {

	float roundTime = 120f;
	int roundNumber = 1;

	public Text round;
	public Text roundTimer;
	public Text roundNumberText;
	public static float timer;

	public Text boxer1Round1;
	public Text boxer2Round1;

	public Text boxer1Round2;
	public Text boxer2Round2;

	public Text boxer1Round3;
	public Text boxer2Round3;

	public Text boxer1Round4;
	public Text boxer2Round4;

	public Text boxer1Total;
	public Text boxer2Total;
	int boxer1Points;
	int boxer2Points;

	public Boxer1Movement boxer1Position;
	public Boxer2Movement boxer2Position;

	public Boxer1Health boxer1HealthIncrease;
	public Boxer2Health boxer2HealthIncrease;

	public Boxer1Stamina boxer1MaxStaminaDecrease;
	public Boxer2Stamina boxer2MaxStaminaDecrease;

	public PointCounter points;
	public int boxer1RoundPoints;
	public int boxer2RoundPoints;

	public KnockDown knockDowns;
	public int boxer1KnockDowns;
	public int boxer2KnockDowns;

	public bool gameOver = false;

	[SerializeField]
	Image player1Wins;
	[SerializeField]
	Image player2Wins;
	[SerializeField]
	Image draw;

	void Start() {
		boxer1Position = FindObjectOfType<Boxer1Movement>();
		boxer2Position = FindObjectOfType<Boxer2Movement>();
		boxer1HealthIncrease = FindObjectOfType<Boxer1Health> ();
		boxer2HealthIncrease  = FindObjectOfType<Boxer2Health> ();
		boxer1MaxStaminaDecrease= FindObjectOfType<Boxer1Stamina> ();
		boxer2MaxStaminaDecrease = FindObjectOfType<Boxer2Stamina> ();
	}
		
	void Update()
	{
		points = FindObjectOfType<PointCounter> ();
		boxer1RoundPoints = points.boxer1Points;
		boxer2RoundPoints = points.boxer2Points;
		knockDowns = FindObjectOfType<KnockDown> ();
		boxer1KnockDowns = knockDowns.boxer1RoundKDs;
		boxer2KnockDowns = knockDowns.boxer2RoundKDs;
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
			if (boxer1RoundPoints > boxer2RoundPoints) {
				if (roundNumber == 1) {
					boxer1Round1.text = "10";
					if (boxer2KnockDowns == 1) {
						boxer2Round1.text = "8";
					} else if (boxer2KnockDowns == 2) {
						boxer2Round1.text = "7";
					} else {
						boxer2Round1.text = "9";
					}
				} else if (roundNumber == 2) {
					boxer1Round2.text = "10";
					if (boxer2KnockDowns == 1) {
						boxer2Round1.text = "8";
					} else if (boxer2KnockDowns == 2) {
						boxer2Round1.text = "7";
					} else {
						boxer2Round2.text = "9";
					}
				} else if (roundNumber == 3) {
					boxer1Round3.text = "10";
					if (boxer2KnockDowns == 1) {
						boxer2Round1.text = "8";
					} else if (boxer2KnockDowns == 2) {
						boxer2Round1.text = "7";
					} else {
						boxer2Round3.text = "9";
					}
				} else if (roundNumber == 4) {
					boxer1Round4.text = "10";
					if (boxer2KnockDowns == 1) {
						boxer2Round1.text = "8";
					} else if (boxer2KnockDowns == 2) {
						boxer2Round1.text = "7";
					} else {
						boxer2Round4.text = "9";
					}
				} 
				boxer1Points = boxer1Points + 10;
				if (boxer2KnockDowns == 1) {
					boxer2Points = boxer2Points + 8;
				} else if (boxer2KnockDowns == 2) {
					boxer2Points = boxer2Points + 7;
				} else {
					boxer2Points = boxer2Points + 9;
				}
				boxer1Total.text = boxer1Points.ToString ();
				boxer2Total.text = boxer2Points.ToString ();
			} else if (boxer1RoundPoints < boxer2RoundPoints) {
				if (roundNumber == 1) {
					boxer1Round1.text = "9";
					boxer2Round1.text = "10";
				} else if (roundNumber == 2) {
					boxer1Round2.text = "9";
					boxer2Round2.text = "10";
				} else if (roundNumber == 3) {
					boxer1Round3.text = "9";
					boxer2Round3.text = "10";
				} else if (roundNumber == 4) {
					boxer1Round4.text = "9";
					boxer2Round4.text = "10";
				} 
				boxer1Points = boxer1Points + 9;
				boxer2Points = boxer2Points + 10;
				boxer1Total.text = boxer1Points.ToString ();
				boxer2Total.text = boxer2Points.ToString ();
			} else {
				if (roundNumber == 1) {
					boxer1Round1.text = "10";
					boxer2Round1.text = "10";
				} else if (roundNumber == 2) {
					boxer1Round2.text = "10";
					boxer2Round2.text = "10";
				} else if (roundNumber == 3) {
					boxer1Round3.text = "10";
					boxer2Round3.text = "10";
				} else if (roundNumber == 4) {
					boxer1Round4.text = "10";
					boxer2Round4.text = "10";
				} 
				boxer1Points = boxer1Points + 10;
				boxer2Points = boxer2Points + 10;
				boxer1Total.text = boxer1Points.ToString ();
				boxer2Total.text = boxer2Points.ToString ();
			}
			boxer1HealthIncrease.roundIncrease ();
			boxer2HealthIncrease.roundIncrease ();
			boxer1MaxStaminaDecrease.decreaseMaxStamina();
			boxer2MaxStaminaDecrease.decreaseMaxStamina();
			roundNumber++;
			knockDowns.boxer1RoundKDs = 0;
			knockDowns.boxer2RoundKDs = 0;
			boxer1KnockDowns = 0;
			boxer2KnockDowns = 0;
			if (roundNumber < 5) {
				roundTime = 120f;
				boxer1Position.resetPosition ();
				boxer2Position.resetPosition ();
				points.resetPoints ();
			} else {
				if (boxer1Points > boxer2Points) {
					player1Wins.enabled = true;
					round.enabled = false;
					roundTimer.enabled = false;
					roundNumberText.enabled = false;
					gameOver = true;
				} else if (boxer1Points < boxer2Points) {
					player2Wins.enabled = true;
					round.enabled = false;
					roundTimer.enabled = false;
					roundNumberText.enabled = false;
					gameOver = true;
				} else {
					draw.enabled = true;
					round.enabled = false;
					roundTimer.enabled = false;
					roundNumberText.enabled = false;
					gameOver = true;
				}

			}
		
		}
	}
}
