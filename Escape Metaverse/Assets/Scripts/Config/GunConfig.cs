using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName ="Gun Config")]
public class GunConfig : ScriptableObject
{
    [SerializeField] Gun gun;
    [SerializeField] GunProjectile gunProjectile;
    [SerializeField] GameObject effect;
    [SerializeField] int numberBullet;
    [SerializeField] int damage;
    [SerializeField] float speed;

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
        return numberBullet;
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
}
