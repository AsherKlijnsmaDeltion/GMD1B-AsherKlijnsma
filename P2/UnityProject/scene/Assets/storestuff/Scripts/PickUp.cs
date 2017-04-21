using UnityEngine;
using System.Collections;

public class PickUp : MonoBehaviour
{
    public RaycastHit hit;
    public Vector3 ray;
    public Transform blade;
    public Transform handle;
    public float range;


    // Use this for initialization
    void Start()
    {
        
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            Debug.DrawRay(transform.position, transform.forward * 100, Color.blue, 5f);
            if (Physics.Raycast(transform.position, transform.forward, out hit, range))
            {
                Debug.Log("Raycast hit; " + hit.transform.name);
                if (hit.transform.name == "blade")
                {
                    GetComponent<Manager>().inventory[0] = true;
                    Destroy(hit.transform.gameObject);
                }
                if(hit.transform.name == "handle")
                {
                    GetComponent<Manager>().inventory[1] = true;
                    Destroy(hit.transform.gameObject);
                }
            }
        }
    }
}

