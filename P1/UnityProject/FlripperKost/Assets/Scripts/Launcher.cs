using UnityEngine;
using System.Collections;

public class Launcher : MonoBehaviour
{
    public Rigidbody rb;
    public float power;
    // Use this for initialization
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }
    // Geef aan wat de rigidbody is
    // Update is called once per frame
    void OnTriggerStay(Collider c)
    {
        if (c.name == "launch") //check of de bal op het platform ligt
        {
            if (Input.GetButtonDown("Jump"))//geef als voorwaarde dat op spatie gedrukt moet worden
            {
                transform.rotation = Quaternion.identity;//zorg ervoor dat de bal goede kant op gaat
                rb.AddForce(transform.forward * power);//schiet bal af
            }
        }
    }
}
