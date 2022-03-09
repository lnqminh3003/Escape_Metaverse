using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName ="Gun Config")]
public class GunConfig : ScriptableObject
{
    [SerializeField] Gun gun;
    [SerializeField] GunProjectile gunProjectile;
    [SerializeField] GameObject effect;

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

    public GameObject GetEffect()
    {
        if (effect == null) return null;
        return effect;
    }
}
