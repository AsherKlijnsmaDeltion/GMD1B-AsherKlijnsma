using UnityEngine;
using System.Collections;

public class Player2 : MonoBehaviour{
    public GameObject man;
    public Vector3 herspawn;
    public GameObject opnieuw;
    public Vector3 beweging;
    public float hoor;
    public float verti;
    public float extra;
    
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        verti = Input.GetAxis("Vertical1");
        hoor = Input.GetAxis("Horizontal1");
        beweging.x = hoor;
        beweging.z = verti;
        herspawn = opnieuw.transform.position;
        transform.Translate(beweging * Time.deltaTime * extra);
    }
    void OnCollisionEnter(Collision c)
    {
        if (c.gameObject.tag == "LRT" || c.gameObject.tag == "RRT")
        {
            Instantiate(man, herspawn, Quaternion.identity);
            Destroy(gameObject);


        }
    }
}
