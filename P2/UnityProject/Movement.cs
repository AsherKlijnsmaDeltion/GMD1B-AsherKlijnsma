using UnityEngine;
using System.Collections;

public class Movement : MonoBehaviour {
    public float speed;
    public float ver;
    public float hor;
    public Vector3 rot;
    public Vector3 movement;
    public Vector3 turn;
    public Vector3 jump;
    public Rigidbody rb;
    public GameObject cam;
    public int count;
    
    // Use this for initialization
    void Start ()
    {
        speed = 5;
	}
	
	// Update is called once per frame
	void Update ()
    {
        turn.y = Input.GetAxis("Mouse X");
        rot.x = Input.GetAxis("Mouse Y");
        cam.transform.Rotate(rot);
        transform.Rotate(turn);

        movement.x = hor;
        movement.z = ver;
        ver = Input.GetAxis("Vertical");
        hor = Input.GetAxis("Horizontal");
        transform.Translate(movement * Time.deltaTime * speed);

        if (count < 3)
        {
            if (Input.GetButtonDown("Jump"))
            {
                rb.velocity = jump;
                count++;
            }
        }
    }
    void OnCollisionEnter(Collision c)
    {
        if (c.gameObject.tag == "Ground")
        {
            count = 0;

        }
    }
}
