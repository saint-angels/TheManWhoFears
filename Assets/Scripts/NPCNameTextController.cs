﻿using UnityEngine;
using System.Collections;

public class NPCNameTextController : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		transform.forward = Camera.main.transform.forward;
	}


}
