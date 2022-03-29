using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShopUI : MonoBehaviour
{
    [SerializeField] GameObject list;
    [SerializeField] ShopItem templateShopItem;

    public void SetData(List<ItemShop> listItem)
    {
        RefreshShopUI(listItem);
    }

    public void RefreshShopUI(List<ItemShop> listItem)
    {
        foreach (var item in listItem)
        {
            var shopItem = Instantiate(templateShopItem);
            shopItem.transform.SetParent(list.transform);

            shopItem.DisplayItem(item);
        }
    }

    public void DestroyItem()
    {
        for (int i =0;i< list.gameObject.transform.childCount; i++)
        {
            Destroy(list.transform.GetChild(i).gameObject); 
        }
    }
}

