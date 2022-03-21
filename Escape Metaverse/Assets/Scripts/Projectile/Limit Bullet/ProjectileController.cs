using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using EnumMetaverse;

public class ProjectileController : MonoBehaviour
{
    [Header("GunConfig")]
    [SerializeField] GunConfig[] gunConfig;

    Dictionary<TypeGun, int> currentProjectile = new Dictionary<TypeGun, int>();
    Dictionary<TypeGun, int> numberProjectile= new Dictionary<TypeGun, int>();

    TypeGun currentTypeGun;

    private void Start()
    {
        for(int i=0;i<gunConfig.Length;i++)
        {
            currentProjectile.Add(gunConfig[i].GetTypeGun(), gunConfig[i].GetNumberBullet());
            numberProjectile.Add(gunConfig[i].GetTypeGun(), gunConfig[i].GetNumberBullet());
        }
    }

    public void DecreaseProjectile()
    {
        currentProjectile[currentTypeGun] -= 1;
    }

    public bool HaveBullet()
    {
        if(currentProjectile[currentTypeGun] <= 0)
        {
            return false;
        }
        return true;
    }

    public int GetNumberCurrentProjectile()
    {
        return currentProjectile[currentTypeGun];
    }
    
    public void SetCurrentTypeGun(TypeGun typeGun)
    {
        this.currentTypeGun = typeGun;
        GetComponent<DisplayProjectile>().ChangeGun(GetSprite());
    }

    public Sprite GetSprite()
    {
        for(int i=0;i< gunConfig.Length;i++)
        {
            if(gunConfig[i].GetTypeGun() == currentTypeGun)
            {
                return gunConfig[i].GetGun().GetComponent<Item>().GetSprite();
            }
        }
        return null;
    }
}
