using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaneTrap : MonoBehaviour
{
    [SerializeField] Trap trap;


    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player" && trap.GetCanDamage() )
        {
            var healthPlayer = other.gameObject.GetComponent<HealthPlayer>();
            healthPlayer.DamagePlayer(healthPlayer.GetHealth());
        }
    }
}
