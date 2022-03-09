using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : MonoBehaviour
{
    [SerializeField] Sprite sprite;

    public Sprite GetSprite()
    {
        return sprite;
    }
}
