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
                if (hit.transform == blade || hit.transform == handle)
                {
                    GameObject.Find("Managing").GetComponent<Manager>().inventory.Add(hit.transform.gameObject);
                    Destroy(hit.transform.gameObject);
                }
            }
        }
    }
}

