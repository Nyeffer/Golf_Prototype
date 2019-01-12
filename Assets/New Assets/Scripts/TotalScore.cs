using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TotalScore : MonoBehaviour {

	public Text[] score;
	public HoleType hole;
	public Hit player;

	void Start() {
		PlayerPrefs.SetString(hole.holeName() + "Score", PlayerPrefs.GetString(hole.holeName() + "Score", " "));
	}

	void Update() {
		PlayerPrefs.SetString(hole.holeName() + "Score", player.WhatScore((hole.GetPar() * -1) + player.GetStroke(), hole.GetPar()));
		score[0].text = PlayerPrefs.GetString("Hole_1Score", " ");
		score[1].text = PlayerPrefs.GetString("Hole_2Score", " ");
		score[2].text = PlayerPrefs.GetString("Hole_3Score", " ");
		score[3].text = PlayerPrefs.GetString("Hole_4Score", " ");
		score[4].text = PlayerPrefs.GetString("Hole_5Score", " ");
		score[5].text = PlayerPrefs.GetString("Hole_6Score", " ");
		score[6].text = PlayerPrefs.GetString("Hole_7Score", " ");
		score[7].text = PlayerPrefs.GetString("Hole_8Score", " ");
		score[8].text = PlayerPrefs.GetString("Hole_9Score", " ");
	}

}
