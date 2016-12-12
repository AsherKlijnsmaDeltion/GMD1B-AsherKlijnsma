using UnityEngine;
using System.Collections;

public class Rayray : MonoBehaviour {
    public RaycastHit hit;
    public int score;
    public Vector3 rara;
	// Use this for initialization
	void Start () {
        
	}   
	
	// Update is called once per frame
	void Update () {
        print(score);
        if (Input.GetButton("Fire1"))
        {
            Debug.DrawRay(transform.position, transform.forward*100, Color.blue,5f);
            if (Physics.Raycast(transform.position, transform.forward, out hit, 500f))
            {
                if (hit.transform.tag == "points")
                    {
                        score++;
                    }
                }
            }
        }
    }

