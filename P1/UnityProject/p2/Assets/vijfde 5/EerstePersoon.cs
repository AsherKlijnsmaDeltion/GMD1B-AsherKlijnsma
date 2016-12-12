using UnityEngine;
using System.Collections;

public class EerstePersoon : MonoBehaviour {
    public Vector3 rotatie;
    public GameObject mcamera;
    public Vector3 draai;
    public float speed;
    public Vector3 move;
    public float hor;
    public float ver;
	// Use this for initialization
	void Start () {
        speed = 10;
	}
	
	// Update is called once per frame
	void Update () {
        rotatie.y = Input.GetAxis("Mouse X");
        draai.x = -Input.GetAxis("Mouse Y");

        move.x = hor;
        move.z = ver;

        mcamera.transform.Rotate(draai);
        transform.Rotate(rotatie);

        ver = Input.GetAxis("Vertical");
        hor = Input.GetAxis("Horizontal");
        transform.Translate(move*Time.deltaTime*speed);


        
    }
}
