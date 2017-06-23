using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InvManager : MonoBehaviour {

    public GameObject heldItem;

    public void Take(GameObject item)
    {
        if (heldItem == null)
        {
            heldItem = item;
        }
    }

    void Follow()
    {
        heldItem.transform.position = Input.mousePosition;
    }

    void Update()
    {
        if(heldItem != null)
        {
            Follow();
        }
    }
}
