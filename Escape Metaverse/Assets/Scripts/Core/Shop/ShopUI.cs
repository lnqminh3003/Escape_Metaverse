using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ShopUI : MonoBehaviour
{
    [SerializeField] GameObject list;
    [SerializeField] TextMeshProUGUI messageText; 

    public void SetData(List<ItemShop> listItem)
    {
        RefreshShopUI(listItem);
    }

    public void RefreshShopUI(List<ItemShop> listItem)
    {
        int i = 0;
        foreach (var item in listItem)
        {
            var child = list.transform.GetChild(i);
            i++;
            child.GetComponent<ShopItem>().DisplayItem(item);
        }
    }

    public void DisplayMessage(string message)
    {
        messageText.text = message;
    }
}

