using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using EnumMetaverse;

public class Coin : MonoBehaviour
{
    public GameObject coin;
    public CoinConfig coinFig;

    public bool checkCollision;
    public Vector3 defaultPosition;
   
    private void Start()
    {
        defaultPosition = coin.transform.position;
        checkCollision = true;
    }

    public virtual void SendSignal()
    {

    }
}
