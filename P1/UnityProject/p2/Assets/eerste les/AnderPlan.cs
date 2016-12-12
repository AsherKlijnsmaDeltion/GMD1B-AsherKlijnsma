using UnityEngine;
using System.Collections;

public class AnderPlan : MonoBehaviour {
    public int plusScore;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
    void OnCollisionEnter(Collision c) {
        c.gameObject.GetComponent<Armor>().ArmorReduction(1000);


    }
}
