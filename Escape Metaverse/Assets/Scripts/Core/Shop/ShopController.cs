using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShopController : MonoBehaviour
{ 
   [SerializeField] ShopUI shopUI;
    Shop shop;

    private void Start()
    {
        shop = FindObjectOfType<Shop>();
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
