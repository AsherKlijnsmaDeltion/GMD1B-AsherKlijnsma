using UnityEngine;
using System.Collections;

public class Axis : MonoBehaviour {
    public Vector3 move;
    public float hoar;
    public float accel;
	// Use this for initialization
	void Start () {
        
	}
	
	// Update is called once per frame
	void Update () {
        hoar = Input.GetAxis("Horizontal");
        move.x = hoar;
        transform.Translate(move*Time.deltaTime*accel);
        if (GameObject.Find("GameController").GetComponent<Database>().lives == 0) {
            Destroy(gameObject);
        }
	}
}
