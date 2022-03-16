using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Projectile Config")]
public class ProjectileConfig : ScriptableObject
{
    [SerializeField] GameObject effect;
    [SerializeField] EnemyProjectile enemyProjectile;
    [SerializeField] int damage;
    [SerializeField] float speed;

    public GameObject GetEffect()
    {
        return effect;
    }

    public EnemyProjectile GetEnemyProjectile()
    {
        return enemyProjectile;
    }

    public int GetDamage()
    {
        return damage;
    }

    public float GetSpeed()
    {
        return speed;
    }
}
