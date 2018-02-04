using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Collider))]
public class CubeController : MonoBehaviour {

	public float angularVelocity;

	// Update is called once per frame
	void Update () {
		if (InFieldOfView ()) {
			ChangeColor (Color.green);
			if (!InDirectFocus ()) {
				// only move the cube when it's not being looked at directly
				Orbit ();
			} else {
				// halt the cube and make it red
				ChangeColor (Color.red);
			}
		} else {
			Orbit ();
			ChangeColor (Color.gray);
			MakeNoiseOutsideFOV ();
		}
	}

	// continuous movement of cube
	void Orbit () {
		transform.RotateAround (new Vector3 (0, 0, 0), Vector3.up, angularVelocity * Time.deltaTime);
	}

	// determine if the cube lies within the user's field of view (FOV)
	bool InFieldOfView () {
		// TODO
//		StereoController stereoCtrl = GvrViewer.Controller;
		return false;
	}


	// determine if the user is looking "directly" at the cube, meaning their eyes are 
	// looking straight ahead
	bool InDirectFocus () {
		// TODO
		return false;
	}

	// set the color of the cube
	void ChangeColor (Color color) {
		Renderer rend = GetComponent<Renderer> ();
		rend.material.color = color;
	}

	// attract the user's attention to the cube when it lies outside their FOV by making noise
	void MakeNoiseOutsideFOV () {
		// TODO: emanate spatial audio
	}
}
