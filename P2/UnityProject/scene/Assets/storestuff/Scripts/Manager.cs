using UnityEngine;
using System.Collections;
using System.Collections.Generic;
public class Manager : MonoBehaviour {
    public List<bool> inventory = new List<bool>();
    public GameObject weapon;
    public GameObject anvil;
    public float lenght;
    public GameObject player;
    public Vector3 anvilPos;
    public float listLength;
    public GameObject sword;
    public Transform playerTransform;
    public Vector3 playerPos;
    public enum State
    {
        Armed,
        Unarmed,
    }
    public State state;
    // Use this for initialization
    void Start()
    {
        
        playerPos.z += 1;   
    
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnCollisionEnter(Collision c)
    {
      
        if (c.transform.tag == "anvil")
        {
            Debug.Log("Anvil found!");
            if (inventory[0] == true && inventory[1] == true)
            {
                inventory[0] = false;
                Debug.Log("Inventory checks out");
                sword = GameObject.Find("sword");
                print("hoi");
                weapon.SetActive(true);

            }
        }
    }
}








