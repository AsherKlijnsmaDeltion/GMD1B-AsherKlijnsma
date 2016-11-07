using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class DeathZone : MonoBehaviour {
    public Text life;
    
    void OnCollisionEnter(Collision C) {

        Destroy(C.gameObject);// vernietig object dat in aanraking komt
        GameObject.Find("DataBase").GetComponent<GameController>().lives -= 1;//haal 1 leven van totaal af
        if(GameObject.Find("DataBase").GetComponent<GameController>().lives > 0)//check of speler nog meer dan 1 leven heeft
        {
           GameObject.Find("SpawnLocation").GetComponent<Swapning>().SpawnBall();// creëer nieuw balletje om af te schieten
        }
            life.text = ("Lives: ") + GameObject.Find("DataBase").GetComponent<GameController>().lives.ToString();//geef overige levens op 
    }
}
