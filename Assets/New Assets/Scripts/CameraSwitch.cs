using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraSwitch : MonoBehaviour {

	// Public Variables
	public Camera birdCam;
	public Camera player;

	// Private Variables
	private bool isBirds = false;

	void Update() {
		birdCam.gameObject.SetActive(isBirds);
		player.gameObject.SetActive(!isBirds);
	}

	public void ChangeCam() {
		isBirds = !isBirds;
	}
}
