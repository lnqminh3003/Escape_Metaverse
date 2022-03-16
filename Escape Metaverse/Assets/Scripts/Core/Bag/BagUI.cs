using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BagUI : MonoBehaviour
{
    [SerializeField] Sprite defaultSprite;
    [SerializeField] GameObject content;

    Dictionary<Item,int> items = new Dictionary<Item,int>();

    public void SetItems(Dictionary<Item, int> items)
    {
        this.items = items;
        DisplayItemToUI();
    }

    private void DisplayItemToUI()
    {
        if (defaultSprite == null || content== null) return;

        AddDefaultSpriteToUI();

        AddItemToUI();
    }
    
    private void AddDefaultSpriteToUI()
    {
        int numberOfChildren = content.transform.childCount;
        for (int i = 0; i < numberOfChildren; i++)
        {
            AddSpriteToList(i,defaultSprite);
        }
    }

    private void AddItemToUI()
    {
        int index = 0;
        foreach (var item in items)
        {
            int num = item.Value;
            for (int i =1;i<=num;i++)
            {
                AddSpriteToList(index, item.Key.GetSprite());
                content.transform.GetChild(index).GetComponent<BagItem>().SetItem(item.Key);
                index++;
            }
        }
    }
    private void AddSpriteToList(int index, Sprite sprite)
    {
        var image = content.transform.GetChild(index).GetChild(0).GetChild(0);
        image.GetComponent<Image>().sprite = sprite;
    }
}
