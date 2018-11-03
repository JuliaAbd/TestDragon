using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName ="New Item", menuName ="Inventoty/Item")]
public class Item : ScriptableObject
{
    new public string name = "Item name";
    public Sprite icon = null;
    public bool isDefault=false;

public abstract void OneMoreAgain(){};
}
