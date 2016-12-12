using UnityEngine;
using System.Collections;

public class Armor : MonoBehaviour {
    public float damage;
	// Use this for initialization
	void Start () {
        //ArmorReduction(1000);
	}
	
	// Update is called once per frame
	void Update () {
	
	}
    public float ArmorReduction(float f)
    {

        f *= 0.12f;
        damage = f;
        return (f);
    }
}
