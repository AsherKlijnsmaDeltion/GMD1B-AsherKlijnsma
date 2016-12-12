using UnityEngine;
using System.Collections;

public class Jump : MonoBehaviour {
    public Vector3 rotatie;
    public GameObject mcamera;
    public Vector3 draai;
    public Vector3 jump;
    public Rigidbody rb;
    public float speed;
    public Vector3 move;
    public float hor;
    public float ver;
    public int getalletje;
    // Use this for initialization
    void Start()
    {
        speed = 10;
    }

    // Update is called once per frame
    void Update()
    {
        rotatie.y = Input.GetAxis("Mouse X");
        draai.x = -Input.GetAxis("Mouse Y");
        mcamera.transform.Rotate(draai);
        transform.Rotate(rotatie);

        move.x = hor;
        move.z = ver;
        ver = Input.GetAxis("Vertical1");
        hor = Input.GetAxis("Horizontal1");
        transform.Translate(move * Time.deltaTime * speed);

        if (getalletje < 3)
        {
            if (Input.GetButtonDown("Jump"))
            {
                rb.velocity = jump;
                getalletje++;
            }
        }
    }

    void OnCollisionEnter(Collision c)
    {
        if (c.gameObject.tag == "Ground")
        {
            getalletje = 0;

        }
    }
}
