using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item:MonoBehaviour
{
    public Item(string name, int  quantity,string sourceImage)
    {
        this.name = name;
        this.quantity = quantity;   
        this.sourceImage = sourceImage;
    }   
    public Item() { }
    public string name;
    public int quantity;
    public string sourceImage;

}