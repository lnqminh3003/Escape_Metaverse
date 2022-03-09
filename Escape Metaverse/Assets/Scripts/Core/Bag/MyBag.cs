using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyBag : MonoBehaviour
{
    Dictionary<Item, int> bagItems = new Dictionary<Item, int>();
    [SerializeField] Item item;

    private void Start()
    {
        AddItemToBag(item, 2);
    }
    public Dictionary<Item,int> GetBagItems()
    {
        return bagItems;
    }

    public void AddItemToBag(Item item, int num)
    {
        if(bagItems.ContainsKey(item))
        {
            bagItems[item] += num;
        }
        else
        {
            bagItems.Add(item,num);
        }
    }
}
