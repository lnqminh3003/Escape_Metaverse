using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShopController : MonoBehaviour
{ 
    ShopUI shopUI;
    Shop shop;

    private void Start()
    {
        shopUI= FindObjectOfType<ShopUI>();
        shop = FindObjectOfType<Shop>();

        shopUI.gameObject.SetActive(false);
    }

    //Button display
    public void DisplayShopUI()
    {
        if (shopUI == null) return;
        shopUI.gameObject.SetActive(true);

        shopUI.SetData(shop.GetListItemShop());
    }

    //Button Exit
    public void ExitShop()
    {
        shopUI.DestroyItem();
        shopUI.gameObject.SetActive(false);
    }
}
