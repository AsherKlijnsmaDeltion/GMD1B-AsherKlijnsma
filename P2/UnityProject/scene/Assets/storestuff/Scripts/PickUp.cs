using UnityEngine;
using System.Collections;

public class PickUp : MonoBehaviour
{
    
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
        
                
                
        }
    
    void OnCollisionEnter(Collision col)
    {
        if (col.transform.name == "blade")
        {
            GetComponent<Manager>().inventory[0] = true;
            Destroy(col.transform.gameObject);
        }
        if (col.transform.name == "handle")
        {
            GetComponent<Manager>().inventory[1] = true;
            Destroy(col.transform.gameObject);
        }
    }
}


