using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shop : MonoBehaviour
{
    [SerializeField] ShopConfig shopConfig;

    List<ItemShop> listItem = new List<ItemShop> ();
    MyBag bag;
    MyWallet wallet;

    private void Start()
    {
        bag = FindObjectOfType<MyBag> ();
        wallet = FindObjectOfType<MyWallet>();
        SetItemToShop();
    }

    private void SetItemToShop()
    {
        GunConfig[] gunConfigs = shopConfig.GetGunConfig();
        for (int i = 0; i < gunConfigs.Length; i++)
        {
            ItemShop item = new ItemShop(gunConfigs[i].GetName(),gunConfigs[i].GetPrice(), gunConfigs[i].GetMaxSupply(),
               gunConfigs[i].GetGun().GetComponent<Item>(),0);   
            listItem.Add(item);
        }
    }

    public List<ItemShop> GetListItemShop()
    {
        return listItem;
    }

    public void PlusButton(ItemShop itemShop)
    {
        if (listItem.Contains(itemShop))
        {
            if (itemShop.count < itemShop.maxSupply)
            {
                itemShop.count++;
                FindObjectOfType<ShopUI>().RefreshShopUI(listItem);
            }
        }
    }

    public void MinusButton(ItemShop itemShop)
    {
        if (listItem.Contains(itemShop))
        {
            if (itemShop.count >0)
            {
                itemShop.count--;
                FindObjectOfType<ShopUI>().RefreshShopUI(listItem);
            }
        }
    }

    public void BuyButton(ItemShop itemShop)
    {
        if (itemShop.price > wallet.MCoin)
        {
            FindObjectOfType<ShopUI>().DisplayMessage("Don't enough MCoin");
            return;
        }
        if(itemShop.count <=0)
        {
            FindObjectOfType<ShopUI>().DisplayMessage("Min buy 1 item");
            return;
        }
        if(itemShop.count >0)
        {
            bag.AddItemToBag(itemShop.item, itemShop.count);
            itemShop.maxSupply -= itemShop.count;
            wallet.SpendMCoin(itemShop.price);
            itemShop.count =0 ;
            FindObjectOfType<ShopUI>().RefreshShopUI(listItem);
            FindObjectOfType<ShopUI>().DisplayMessage("Success");
        }
    }
}

