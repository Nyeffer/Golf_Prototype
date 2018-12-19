using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TotalScore : MonoBehaviour {

	public Text[] score;

	public int[] number;

	void Start() {
		PlayerPrefs.SetInt("hole1", PlayerPrefs.GetInt("hole1", 0));
		PlayerPrefs.SetInt("hole2", PlayerPrefs.GetInt("hole2", 0));
		PlayerPrefs.SetInt("hole3", PlayerPrefs.GetInt("hole3", 0));
		PlayerPrefs.SetInt("hole4", PlayerPrefs.GetInt("hole4", 0));
		PlayerPrefs.SetInt("hole5", PlayerPrefs.GetInt("hole5", 0));
		PlayerPrefs.SetInt("hole6", PlayerPrefs.GetInt("hole6", 0));
		PlayerPrefs.SetInt("hole7", PlayerPrefs.GetInt("hole7", 0));
		PlayerPrefs.SetInt("hole8", PlayerPrefs.GetInt("hole8", 0));
		PlayerPrefs.SetInt("hole9", PlayerPrefs.GetInt("hole9", 0));
	}

	void Update() {
		score[0].text = PlayerPrefs.GetInt("hole1", 0).ToString();
		score[1].text = PlayerPrefs.GetInt("hole2", 0).ToString();
		score[2].text = PlayerPrefs.GetInt("hole3", 0).ToString();
		score[3].text = PlayerPrefs.GetInt("hole4", 0).ToString();
		score[4].text = PlayerPrefs.GetInt("hole5", 0).ToString();
		score[5].text = PlayerPrefs.GetInt("hole6", 0).ToString();
		score[6].text = PlayerPrefs.GetInt("hole7", 0).ToString();
		score[7].text = PlayerPrefs.GetInt("hole8", 0).ToString();
		score[8].text = PlayerPrefs.GetInt("hole9", 0).ToString();
	}

}
