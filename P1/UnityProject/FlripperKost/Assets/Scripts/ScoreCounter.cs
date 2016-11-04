    using UnityEngine;
using System.Collections;

public class ScoreCounter : MonoBehaviour {
    GameController script;
	// Use this for initialization
	void Start () {
       script = GameObject.Find("DataBase").GetComponent<GameController>();
    }
	
	// Update is called once per frame
	void Update () {
	
	}
    void OnCollisionEnter()
    {
        script.score = script.score + 100;
        
    }
}
