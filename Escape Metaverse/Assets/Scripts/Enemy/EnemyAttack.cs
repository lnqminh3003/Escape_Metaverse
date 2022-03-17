using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAttack : MonoBehaviour
{
    [SerializeField] ProEnemyConfig projectileConfig;
    [SerializeField] GameObject gun;
    [SerializeField] GameObject target;
    [SerializeField] float seconds;

    float countTime;
    EnemyProjectile enemyProjectile;
    GameObject effectDamage;
    float speed;
    int damage;

    private void Start()
    {
        countTime = seconds;

        enemyProjectile = projectileConfig.GetEnemyProjectile();
        effectDamage = projectileConfig.GetEffect();
        speed = projectileConfig.GetSpeed();
        damage = projectileConfig.GetDamage();
    }
    private void Update()
    {
        if (countTime >= seconds)
        {
            Fire();
            countTime = 0;
        }
        else
        {
            countTime += Time.deltaTime;
        }
    }
    private void Fire()
    {
        var pro = Instantiate(enemyProjectile, gun.transform.position, Quaternion.identity);
        pro.setFeature(target ,effectDamage,speed, damage );
        Destroy(pro.gameObject, 10f);
    }

}
