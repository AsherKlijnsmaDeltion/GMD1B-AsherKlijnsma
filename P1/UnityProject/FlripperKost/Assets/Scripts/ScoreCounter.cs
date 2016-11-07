using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ScoreCounter : MonoBehaviour {
    public ParticleSystem system;
    GameController script;
    public AudioSource bumper;
    public Text totalScore;
	// Use this for initialization
	void Start () {
       script = GameObject.Find("DataBase").GetComponent<GameController>();// geef aan welk script gepakt moet worden
    }
	
    void OnCollisionEnter()
    {
        script.score = script.score + 100;//voeg 100 aan score toe
        bumper.Play();// speel sound effect voor bumper aanraken af
        totalScore.text = ("Score: ") + script.score.ToString();//geef score aan op UI
        system.Emit(280);//laat particles afgaan bij aanraking
    
    }
}
