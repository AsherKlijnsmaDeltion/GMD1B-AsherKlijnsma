using UnityEngine;
using System.Collections;

public class ExtraBall : MonoBehaviour {
    public GameObject spawner;
    public GameObject ball;
    public Vector3 locatie;
	// Use this for initialization
	void Start () {
        locatie = transform.position;//geef aan wat de locatie moet zijn
	}
	
    void OnCollisionEnter() {

        Instantiate(ball, locatie, Quaternion.identity);//creëer nieuw balletje
        Destroy(gameObject);//vernietig dit object
        
    }
}
