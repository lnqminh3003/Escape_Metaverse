using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using EnumMetaverse;

[CreateAssetMenu(menuName ="Gun Config")]
public class GunConfig : ScriptableObject
{
    [SerializeField] string nameGun;
    [SerializeField] Gun gun;
    [SerializeField] GunProjectile gunProjectile;
    [SerializeField] GameObject effect;
    [SerializeField] int numberEachReset;
    [SerializeField] int damage;
    [SerializeField] float speed;
    [SerializeField] int maxNumberSupply;
    [SerializeField] int price;
    [SerializeField] TypeGun typeGun;


    public string GetName()
    {
        return nameGun;
    }

    public Gun GetGun()
    {
        if(gun == null) return null;
        return gun;
    }

    public GunProjectile GetGunProjectile()
    {
        if(gunProjectile == null) return null;
        return gunProjectile;
    }

    public int GetNumberBullet()
    {
        return numberEachReset;
    }

    public int GetDamage()
    {
        return damage;
    }

    public float GetSpeed()
    {
        return speed;
    }

    public GameObject GetEffect()
    {
        if (effect == null) return null;
        return effect;
    }

    public TypeGun GetTypeGun()
    {
        return typeGun;
    }

    public int GetMaxSupply()
    {
        return maxNumberSupply;
    }

    public int GetPrice()
    {
        return price;
    }
}
