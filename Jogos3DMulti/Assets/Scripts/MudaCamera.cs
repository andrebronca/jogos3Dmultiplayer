using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MudaCamera : MonoBehaviour {

	public Camera[] Cameras;

	// Use this for initialization
	void Start () {
		Cameras[0].enabled = true;
		Cameras[1].enabled = false;
		Cameras[2].enabled = false;
		Cameras[3].enabled = false;
	}
	
	// Update is called once per frame
	void Update () {

		if (Input.GetKeyDown(KeyCode.M))
		{
			Cameras[0].enabled = true;
			Cameras[1].enabled = false;
			Cameras[2].enabled = false;
			Cameras[3].enabled = false;
		}
		
		if (Input.GetKeyDown(KeyCode.J))
		{
			Cameras[0].enabled = false;
			Cameras[1].enabled = true;
			Cameras[2].enabled = false;
			Cameras[3].enabled = false;
		}

		if (Input.GetKeyDown(KeyCode.K))
		{
			Cameras[0].enabled = false;
			Cameras[1].enabled = false;
			Cameras[2].enabled = true;
			Cameras[3].enabled = false;
		}

		if (Input.GetKeyDown(KeyCode.L))
		{
			Cameras[0].enabled = false;
			Cameras[1].enabled = false;
			Cameras[2].enabled = false;
			Cameras[3].enabled = true;
		}
	}
}
