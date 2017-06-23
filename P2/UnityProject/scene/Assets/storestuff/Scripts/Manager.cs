using UnityEngine;
using System.Collections;
using System.Collections.Generic;
public class Manager : MonoBehaviour {
    public List<bool> inventory = new List<bool>();
    public GameObject weapon;
    public GameObject anvil;
    public RaycastHit target;
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
        anvilPos = anvil.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire2"))
        {
            Debug.DrawRay(transform.position, transform.forward * 100, Color.red, 5f);
            if (Physics.Raycast(transform.position, transform.forward, out target, lenght))
            {
                print("Raycasted for Anvil");
                if (target.transform.tag == "anvil")
                {
                    Debug.Log("Anvil found!");
                        if (inventory[0]  == true && inventory[1] == true)
                        {
                             // Instantiates the weapon at the player position and passes the GameObject variable on to the Parent function
                            Parent((GameObject)Instantiate(weapon, playerPos, Quaternion.identity));
                            inventory[0] = false;
                            Debug.Log("Inventory checks out");
                            sword = GameObject.Find("sword");
                        }
                  }
            }
        }
        if (Input.GetButtonDown("1"))
        {
            SwitchOn();
        }
        if (Input.GetButtonDown("2"))
        {
            SwitchOff();
        }
    }
    // Parents the weapon GameObject to the player GameObject
    public void Parent(GameObject sword)
    {
        sword.transform.parent = player.transform;
    }
    public void SwitchOn()
    {
        state = State.Armed;
            if (state == State.Armed)
            {
                sword.SetActive(true);
            }
        }
        
    public void SwitchOff()
    {
        state = State.Unarmed;
            if (state == State.Unarmed)
            {
                sword.SetActive(false);
            }
        }
    }
 

     

