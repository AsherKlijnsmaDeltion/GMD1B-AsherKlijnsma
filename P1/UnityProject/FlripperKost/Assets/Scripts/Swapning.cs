﻿using UnityEngine;
using System.Collections;

public class Swapning : MonoBehaviour {
    public GameObject balls;
    public Vector3 location;
	// Use this for initialization
	void Start () {
        location = transform.position;
	}
	
	// Update is called once per frame

    public void SpawnBall() {

        Instantiate(balls, location, Quaternion.identity);
    }
}