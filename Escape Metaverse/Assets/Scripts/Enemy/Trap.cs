using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class Trap : MonoBehaviour
{
    Animator trapController;
    bool canDamage;

    private void Start()
    {
        trapController = GetComponent<Animator>();
        canDamage = false;
    }
    public bool GetCanDamage()
    {
        return canDamage;
    }

    //Animation event 
    private void ChangeCanDamage()
    {
        canDamage = !canDamage;
    }

  
}
