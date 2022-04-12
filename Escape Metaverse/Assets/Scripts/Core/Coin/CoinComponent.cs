using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using EnumMetaverse;

public class CoinComponent : MonoBehaviour
{
   [SerializeField] Coin coinControl;

 
    private void OnTriggerEnter(Collider other)
    {
        if(other.tag =="Player")
        {
            coinControl.SendSignal();
        }
    }
}
