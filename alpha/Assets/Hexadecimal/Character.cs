using UnityEngine;
using System;
using System.Collections;

public abstract class Character : MonoBehaviour {

	/// <summary>
	/// 牌号
	/// </summary>
	abstract public int ID { get; }

	/// <summary>
	///
	/// </summary>
	abstract public int HP { get; set; }

	abstract public int MP { get; set; }

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
