using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Hit : MonoBehaviour {

	// Public Variable
	public float force = 0.0f;
	public Rigidbody rb;
	public HoleType hole;
	public GroundCheck gc;
	public GameObject beforeFiring;
	public GameObject currentlyFiring;
	public GameObject Chart;
	public Slider powerMeter;
	public int multiplier = 10;
	public string reset = " ";
	public string after = " ";
	public float timeToEnd = 3.0f;
	
	// Private Variables
	private int score = 0;
	private int stroke = 0;
	private float powerCounter = 0.0f;
	private bool readyToFire = false;
	private bool pos = true;
	private bool firing = false;
	private float counter = 0.0f;
	private bool Done = false;

	void Start() {
		Done = false;
		score = hole.GetPar() * -1;
		beforeFiring.SetActive(true);
		currentlyFiring.SetActive(false);
		Chart.SetActive(false);
	}

	void Update() {
		if(Done) {
			beforeFiring.SetActive(false);
			currentlyFiring.SetActive(false);
			Chart.SetActive(true);
			if(counter < timeToEnd) {
				counter += Time.deltaTime;
			} else {
				Debug.Log(hole.GetisPrac());
				if(hole.GetisPrac()) {
				SceneManager.LoadScene("Menu", LoadSceneMode.Single);
				} else {
					WhatScore(score, hole.GetPar());
					SceneManager.LoadScene(after, LoadSceneMode.Single);
					Debug.Log(WhatScore(score, hole.GetPar()));
				}
			}
		} else {
			if(!readyToFire) {
			beforeFiring.SetActive(true);
			currentlyFiring.SetActive(false);
			} else {
				beforeFiring.SetActive(false);
				currentlyFiring.SetActive(true);
				if(pos) {
					if(powerCounter < powerMeter.maxValue) {
						powerCounter += (Time.deltaTime * multiplier);
						powerMeter.value = powerCounter;
					} else {
						
						multiplier *= -1;
						pos = false;
					}
				} else {
					if(powerCounter > 0.0f) {
						powerCounter += (Time.deltaTime * multiplier);
						powerMeter.value = powerCounter;
					} else {
						multiplier *= -1;
						pos = true;
					}
				}
			}
		}
	}
	public void Shoot() {
		force = powerCounter;
		rb.AddForce(rb.gameObject.transform.forward * force, ForceMode.Impulse);
		score += 1;
		stroke += 1;
		readyToFire = false;
	}

	public void Ready() {
		readyToFire = true;
	}

	public int GetStroke() {
		return stroke;
	}

	void OnTriggerEnter(Collider col) {
		if(col.gameObject.tag == "Goal") {
			Done = true;
		}
	}

	void OnCollisionEnter(Collision col) {
		if(col.gameObject.tag == "Death") {
			SceneManager.LoadScene(reset, LoadSceneMode.Single);
		}
	}

	void OnTriggerExit(Collider col) {
		if(col.gameObject.tag == "DeathZone") {
			SceneManager.LoadScene(reset, LoadSceneMode.Single);
		}
	}

	public void SetFiring(bool newVal) {
		firing = newVal;
	}

	public string WhatScore(int points, int par) {
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
