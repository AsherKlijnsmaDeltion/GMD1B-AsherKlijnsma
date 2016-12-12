using UnityEngine;
using System.Collections;

public class Instantiate : MonoBehaviour {
    public Vector3 position;
    public float posx;
    public GameObject gBal;
    public GameObject sBal;
	// Use this for initialization
	void Start () {
        InvokeRepeating("SpawnBallG", 0, 1.5f);
        InvokeRepeating("SpawnBallS", 0, 1.5f);
	}

    // Update is called once per frame
    void Update() {
        position.x = posx;
        posx = Random.Range(-10f, 10f);

    }


    void SpawnBallG() {

        Instantiate(gBal, position, Quaternion.identity);

        

    }

    void SpawnBallS(){

        Instantiate(sBal, position, Quaternion.identity);

    }
      
}

