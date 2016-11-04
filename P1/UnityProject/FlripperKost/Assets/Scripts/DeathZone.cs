using UnityEngine;
using System.Collections;

public class DeathZone : MonoBehaviour {

	// Use this for initialization

    void OnCollisionEnter(Collision C) {

        Destroy(C.gameObject);
        GameObject.Find("DataBase").GetComponent<GameController>().lives -= 1;
        if(GameObject.Find("DataBase").GetComponent<GameController>().lives > 0){
           GameObject.Find("SpawnLocation").GetComponent<Swapning>().SpawnBall();
        }
    }
}
