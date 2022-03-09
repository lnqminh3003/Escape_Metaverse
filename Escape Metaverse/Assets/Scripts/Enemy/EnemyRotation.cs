using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyRotation : MonoBehaviour
{
    [SerializeField] int damage;

    HealthPlayer healthPlayer;

    private void Start()
    {
        healthPlayer = GameObject.FindWithTag("Player").GetComponent<HealthPlayer>();
    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.tag =="Player")
        {
            healthPlayer.DamagePlayer(damage);
        }
    }
}
