using UnityEngine;
using System.Collections;

public class LekkerSchieten : MonoBehaviour {
    public RaycastHit hit;
    public GameObject bal;
    public Rigidbody rd;
    
	// Use this for initialization
	void Start ()
    {
	
	}
	
	// Update is called once per frame
	void Update ()
    {
        if (Input.GetButtonDown("Fire2"))
        {
            Instantiate(bal,transform.position, Quaternion.identity);
            
        }
        if (Input.GetButtonDown("Fire1"))
        {
            if (Physics.Raycast(transform.position, transform.forward, out hit, 100f))
            {

            }
        }
	}
}
