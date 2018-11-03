using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour {

    public static Inventory instance;

    public int space = 20;

    public delegate void OnItemChanged();
    public OnItemChanged onItemChangedCallBack;
    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
    }

    public List<Item> items = new List<Item>();
    // Use this for initialization

    public bool Add(Item item)
    {
        if (!item.isDefault)
        {
            if (items.Count >= space)
            {
                return false;
            }

            items.Add(item);
            if (onItemChangedCallBack != null)
                onItemChangedCallBack.Invoke();
        }
        return true;
    }

    public void Remove(Item item)
    {
        items.Remove(item);
        if (onItemChangedCallBack != null)
            onItemChangedCallBack.Invoke();
    }
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
