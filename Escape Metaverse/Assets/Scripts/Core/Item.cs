using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using EnumMetaverse;

public class Item : MonoBehaviour
{
    [SerializeField] Sprite sprite;
    [SerializeField] TypeItem typeItem;

    public Sprite GetSprite()
    {
        return sprite;
    }

    public TypeItem GetTypeItem()
    {
        return typeItem;
    }
}
