using UnityEngine;
using System.Collections;

public class InstLRow : MonoBehaviour {
    public Vector3 posi;
    public GameObject traffik;
    public GameObject locatie;
    public Vector3 pos;
    public GameObject plek;
    public GameObject traffic;
    // Use this for initialization
    void Start () {
        InvokeRepeating("SpawnKar", 0, 1);
    }
	
	// Update is called once per frame
	void SpawnKar () {
        posi = locatie.transform.position;
        pos = plek.transform.position;
        Instantiate(traffic, pos, Quaternion.identity);
        Instantiate(traffik, posi, Quaternion.identity);
    }
}
