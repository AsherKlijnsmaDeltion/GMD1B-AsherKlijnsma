using UnityEngine;
using System.Collections;

public class ExtraBall : MonoBehaviour {
    public GameObject spawner;
    public GameObject ball;
    public Vector3 locatie;
	// Use this for initialization
	void Start () {
        locatie = transform.position;
	}
	
    void OnCollisionEnter() {

        Instantiate(ball, locatie, Quaternion.identity);
        Destroy(gameObject);
        
    }
}
