using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemSlot : MonoBehaviour {

    public GameObject item;
    public InvManager manager;
    public bool filled;
    void Start()
    {
        if(item != null)
        {
            filled = true;
        }
        manager = GameObject.FindWithTag("Managing").GetComponent<InvManager>();
        gameObject.GetComponent<Button>().onClick.AddListener(() => {if(filled){manager.Take(item); filled = false; item = null; } else {Place(manager.heldItem);}});
    }

    void Place(GameObject g)
    {
        item = g;
        manager.heldItem = null;
        item.transform.position = transform.position;
        filled = true;
    }
}
