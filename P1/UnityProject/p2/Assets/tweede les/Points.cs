using UnityEngine;
using System.Collections;

public class Points : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
    void OnCollisionEnter(Collision c) {

        if (c.gameObject.name == "Player") {
            GameObject.Find("GameController").GetComponent<Database>().score += 1;
            Destroy(gameObject);
        }
        if (c.gameObject.name == "Ground")
        {
            Destroy(gameObject);
        }
    }
}
