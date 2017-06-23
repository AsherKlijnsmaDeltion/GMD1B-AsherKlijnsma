using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ReadSlot : MonoBehaviour {

    public ItemSlot itemSlot;
    public ItemStats stats;
    public Text reader;

    void Start()
    {
        itemSlot = GetComponent<ItemSlot>();
    }

    void Update()
    {
        if (itemSlot.item != null)
        {
            stats = itemSlot.item.GetComponent<ItemStats>();
            reader.text = stats.itemName + "\r\n" + stats.boostType + stats.boostAmount.ToString() + "\r\n" + stats.flavourText;
        }

        else
        {
            reader.text = null;
        }
    }

}
