using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun : MonoBehaviour
{
    [SerializeField] GunConfig gunConfig;
    [SerializeField] GameObject[] gun;
    [SerializeField] GameObject[] target;

    GunProjectile projectile;
    int numberOfChild;

    private void Start()
    {
        projectile= gunConfig.GetGunProjectile();
        numberOfChild = transform.childCount;
    }

    public void Fire()
    {
        if(numberOfChild ==2)
        {
            for(int i =0;i<2;i++)
            {
                var pro = Instantiate(projectile, gun[i].transform.position, Quaternion.identity);
                pro.SetFeature(gunConfig, target[i]);
            }
        }
        else
        {
            var pro = Instantiate(projectile, gun[0].transform.position, Quaternion.identity);
            pro.SetFeature(gunConfig, target[0]);
        }
    }
}

