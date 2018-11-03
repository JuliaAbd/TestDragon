using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryUI : MonoBehaviour {

    Inventory inventory;
	// Use this for initialization
	void Start ()
    {
        inventory = Inventory.instance;
        inventory.onItemChangedCallBack += UpdateUI;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    void UpdateUI()
    {
        print("Updating Inventory");
    }
}
