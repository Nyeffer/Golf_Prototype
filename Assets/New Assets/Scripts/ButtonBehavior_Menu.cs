using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonBehavior_Menu : MonoBehaviour {

	public GameObject Menu;
	public GameObject Practice;

	void Start() {
		PlayerPrefs.SetInt("Hole_1", 0);
		PlayerPrefs.SetInt("Hole_2", 0);
		PlayerPrefs.SetInt("Hole_3", 0);
		PlayerPrefs.SetInt("Hole_4", 0);
		PlayerPrefs.SetInt("Hole_5", 0);
		PlayerPrefs.SetInt("Hole_6", 0);
		PlayerPrefs.SetInt("Hole_7", 0);
		PlayerPrefs.SetInt("Hole_8", 0);
		PlayerPrefs.SetInt("Hole_9", 0);
	}
	public void GoToPracticeMenu() {
		Menu.SetActive(false);
		Practice.SetActive(true);
	}

	public void GoBack() {
		Menu.SetActive(true);
		Practice.SetActive(false);
	}

	public void PlayPractice(int holeNum) {
		string name = "Hole_" + holeNum.ToString() + "";
		PlayerPrefs.SetInt(name, 0);
		SceneManager.LoadScene(name, LoadSceneMode.Single);
	}
	
}
