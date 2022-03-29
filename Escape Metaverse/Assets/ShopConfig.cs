using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName ="Shop Config")]
public class ShopConfig : ScriptableObject
{
    [Header("Gun")]
    [SerializeField] GunConfig[] gunConfig;

    public GunConfig[] GetGunConfig()
    {
        return gunConfig;
    }
}
