using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Meta.Enum;

public class EnemyAttack : MonoBehaviour
{
    [SerializeField] EnemyProjectile projectile;
    [SerializeField] GameObject gun;
    [SerializeField] GameObject target;
    [SerializeField] float seconds;
    [SerializeField] EnemyType enemyType;

    GameObject effectDamage;
    float countTime;

    private void Start()
    {
        effectDamage = Resources.Load<GameObject>("EffectDamage/" + enemyType);
        countTime = seconds;
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
        var pro = Instantiate(projectile, gun.transform.position, Quaternion.identity);
        pro.setDirection(target ,effectDamage);
        Destroy(pro.gameObject, 2f);
    }

}
