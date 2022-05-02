using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class ShopItem : MonoBehaviour
{
    [SerializeField] GameObject image;
    [SerializeField] TextMeshProUGUI nameItem;
    [SerializeField] TextMeshProUGUI price;
    [SerializeField] TextMeshProUGUI maxNumber;
    [SerializeField] TextMeshProUGUI count;
    [SerializeField] Button plusButton;
    [SerializeField] Button minusButton;
    [SerializeField] Button buyButton;

    ItemShop itemShop;
    Shop shop;

    private void Start()
    {
        shop = FindObjectOfType<Shop>();

        plusButton.GetComponent<Button>().onClick.AddListener(PlusButton);
        minusButton.GetComponent<Button>().onClick.AddListener(MinusButton);
        buyButton.GetComponent<Button>().onClick.AddListener(BuyButton);
    }

    public void DisplayItem(ItemShop itemShop)
    {
        this.itemShop = itemShop;
        image.GetComponent<Image>().sprite = itemShop.sprite;
        nameItem.text = itemShop.name;
        this.price.text = itemShop.price.ToString();
        this.maxNumber.text = itemShop.maxSupply.ToString();
        this.count.text = itemShop.count.ToString();
    }

    private void PlusButton()
    {
        shop.PlusButton(itemShop);
    }

    private void MinusButton()
    {
        shop.MinusButton(itemShop);
    }

    private void BuyButton()
    {
        shop.BuyButton(itemShop);
    }

}
