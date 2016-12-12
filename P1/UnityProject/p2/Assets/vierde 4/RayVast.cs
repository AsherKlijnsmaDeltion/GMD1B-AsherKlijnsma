using UnityEngine;
using System.Collections;

public class RayVast : MonoBehaviour {
    private RaycastHit hit;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        if (Physics.Raycast(transform.position,Vector3.forward,out hit,100.0f))
        {
            if (hit.transform.name == "Sphere")
            {
                print("woman");
            }
        }
	}
}
