using UnityEngine;
using System.Collections;

public class Overloading2 : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
    void OnCollisionEnter(Collision c) {
        GameObject.Find("Main Camera").GetComponent<Remembrance>().TestVoid(20);


    }
}
