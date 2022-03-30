using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class ItemShop
{
    public string name;
    public int price;
    public int maxSupply;
    public Item item;
    public Sprite sprite;
    public int count;

    public ItemShop(string name, int price, int maxSupply, Item item, int count)
    {
        this.name = name;
        this.price = price;
        this.maxSupply = maxSupply;
        this.item = item;
        this.sprite = item.GetSprite();
        this.count = count;
    }
}
