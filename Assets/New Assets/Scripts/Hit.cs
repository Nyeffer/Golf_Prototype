using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Hit : MonoBehaviour {

	// Public Variable
	public float force = 100;
	public Rigidbody rb;
	public HoleType hole;
	public GroundCheck gc;
	public GameObject beforeFiring;
	public GameObject currentlyFiring;
	public Slider powerMeter;
	
	// Private Variables
	private int score = 0;
	private float powerCounter = 0.0f;
	private bool readyToFire = false;
	private bool firing = false;

	void Start() {
		score = hole.GetPar() * -1;
		beforeFiring.SetActive(true);
		currentlyFiring.SetActive(false);
	}

	void Update() {
		if(gc.GetGrounded() && !readyToFire) {
			beforeFiring.SetActive(true);
			currentlyFiring.SetActive(false);
		} else if(gc.GetGrounded() && readyToFire) {
			beforeFiring.SetActive(false);
			currentlyFiring.SetActive(true);
		}
	}
	public void Shoot() {
		rb.AddForce(rb.gameObject.transform.forward * force, ForceMode.Impulse);
	}

	void OnTriggerEnter(Collider col) {
		if(col.gameObject.tag == "Goal") {
			Debug.Log(WhatScore(score, hole.GetPar()));
			WhatScore(score, hole.GetPar());
			SceneManager.LoadScene("Prototype", LoadSceneMode.Single);
		}
	}

	string WhatScore(int points, int par) {
		string name = " ";
		switch(par) {
			case 5:
				switch(points) {
					case -4:
						name = "Hole in One";
					break;
					case -3:
						name = "Double Eagle";
					break;
					case -2:
						name = "Eagle";
					break;
					case -1:
						name = "Birdie";
					break;
					case 0:
						name = "Par";
					break;
					case 1:
						name = "Boogie";
					break;
					case 2:
						name = "Double Boogie";
					break;
					case 3:
						name = "Triple Boogie";
					break;
					case 4:
						name = "Plus 4";
					break;
					case 5:
						name = "Plus 5";
					break;
					case 6:
						name = "Plus 6";
					break;
					default:
					break;
				}
			break;
			case 4:
				switch(points) {
					case -3:
						name = "Hole in One";
					break;
					case -2:
						name = "Eagle";
					break;
					case -1:
						name = "Birdie";
					break;
					case 0:
						name = "Par";
					break;
					case 1:
						name = "Boogie";
					break;
					case 2:
						name = "Double Boogie";
					break;
					case 3:
						name = "Triple Boogie";
					break;
					case 4:
						name = "Plus 4";
					break;
					case 5:
						name = "Plus 5";
					break;
					case 6:
						name = "Plus 6";
					break;
					default:
					break;
				}
			break;
			case 3:
				switch(points) {
					case -2:
						name = "Hole in One";
					break;
					case -1:
						name = "Birdie";
					break;
					case 0:
						name = "Par";
					break;
					case 1:
						name = "Boogie";
					break;
					case 2:
						name = "Double Boogie";
					break;
					case 3:
						name = "Triple Boogie";
					break;
					case 4:
						name = "Plus 4";
					break;
					case 5:
						name = "Plus 5";
					break;
					case 6:
						name = "Plus 6";
					break;
					default:
					break;
				}
			break;
			default:
			break;
		}
		return name;
	}
}
