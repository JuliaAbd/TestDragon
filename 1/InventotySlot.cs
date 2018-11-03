using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventotySlot : MonoBehaviour {

    Item item;

    public void AddItem(Item newItem)
    {
        item = newItem;
    }
}
