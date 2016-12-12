using UnityEngine;
using System.Collections;

public class Movement : MonoBehaviour {
    public Vector3 moving;
    public float hor;
    public float forward;
    public float bonus;
    public GameObject manneke;
    public Vector3 respawn;
    void Start () {
	    
	}
	
	// Update is called once per frame
	void Update () {
        respawn = GameObject.Find("RespawnLoc").transform.position;
        hor = Input.GetAxis("Horizontal");
        forward = Input.GetAxis("Vertical");
        moving.x = hor;
        moving.z = forward;
        transform.Translate(moving * Time.deltaTime* bonus);
    }
    void OnCollisionEnter(Collision c){
        if (c.gameObject.tag == "LRT"||c.gameObject.tag == "RRT") {
            Instantiate(manneke, respawn, Quaternion.identity);
            Destroy(gameObject);

            
        }
    
    
    }

}
