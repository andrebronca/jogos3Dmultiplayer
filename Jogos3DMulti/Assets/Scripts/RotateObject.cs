using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateObject : MonoBehaviour {

	public GameObject obj;
	public float velocidade;

	// Use this for initialization
	void Start () {
		
	}

	// Update is called once per frame
	void Update()
	{
		obj.transform.Rotate(0, 0, velocidade);
	}
}
