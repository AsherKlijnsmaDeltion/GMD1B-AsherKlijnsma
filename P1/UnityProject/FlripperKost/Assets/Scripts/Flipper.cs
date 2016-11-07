using UnityEngine;
using System.Collections;

public class Flipper : MonoBehaviour
{
    public float flipperStrenght;
    public float force;
    public GameObject rFlipper, lFlipper;

    
    void FixedUpdate()
    {

        if (Input.GetButtonDown("Q"))
        {
            LeftFlipper();//bij Q gebruik deze functie
        }


        if (Input.GetButtonDown("E"))
        {
            RightFlipper();// bij E gebruik deze functie
        }
    }
    private void RightFlipper()
    {
        Vector3 f = -transform.up * flipperStrenght;
        Vector3 p = (-transform.right) + transform.position * force;
        rFlipper.GetComponent<Rigidbody>().AddForceAtPosition(f, p); //stuur de rechter flipper aan en geef force mee aan het balletje
    }
    private void LeftFlipper()
    {
        Vector3 f = transform.up * flipperStrenght;
        Vector3 p = (transform.right) + transform.position * force;
        lFlipper.GetComponent<Rigidbody>().AddForceAtPosition(f, p);// stuur de linker flipper aan en geef force mee aan het balletje
    }
}
