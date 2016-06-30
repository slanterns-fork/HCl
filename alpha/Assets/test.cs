using UnityEngine;
using System.Collections;
using System;

public class test : MonoBehaviour {

	public float delay = 200f;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		var x = transform.position;
		transform.position = new Vector3(x.x, x.y + (float)Math.Sin(Time.time+delay));
	}
}
