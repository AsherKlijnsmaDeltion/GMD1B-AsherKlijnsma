﻿using UnityEngine;
using System.Collections;

public class Overloading : MonoBehaviour {
    
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
    void OnCollisionEnter(Collision c) {
        GameObject.Find("Main Camera").GetComponent<Remembrance>().TestVoid(10);

    }
}