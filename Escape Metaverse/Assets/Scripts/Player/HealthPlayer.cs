using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthPlayer : MonoBehaviour
{
    [SerializeField] int health;

    public int GetHealth ()
    {
        return health;
    }
    public void DamagePlayer(int damage )
    {
        health -= damage;
        if(health <=0)
        {
            Debug.Log("DIE");
        }
    }
}
