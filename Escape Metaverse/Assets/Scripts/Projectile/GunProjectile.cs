using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunProjectile : MonoBehaviour
{
    GunConfig gunConfig;
    float speed;
    int damage;
    bool canFire = false;

    private void Update()
    {
        if (!canFire) return;
        Fire();
    }

    public void SetFeature(GunConfig config, GameObject target)
    { 
        this.gunConfig = config;
        transform.LookAt(target.transform);
        speed = config.GetSpeed();
        damage = config.GetDamage();

        canFire = true;
    }

    private void Fire()
    {
        transform.Translate(Vector3.forward * speed * Time.deltaTime);
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag=="Enemy")
        {
            Debug.Log("Kill Enemy");
        }
    }


}
