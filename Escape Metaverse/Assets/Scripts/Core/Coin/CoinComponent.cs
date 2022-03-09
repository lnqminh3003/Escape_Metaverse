using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinComponent : MonoBehaviour
{
    Coin coinControl;
    private void Start()
    {
        coinControl = FindObjectOfType<Coin>();
    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.tag =="Player")
        {
            coinControl.SendSignal();
        }
    }
}
