using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using EnumMetaverse;

public class Coin : MonoBehaviour
{
    [SerializeField] GameObject coin;
    [SerializeField] CoinConfig coinFig;
    [SerializeField] TypeCoin typeCoin;

    bool checkCollision;
    Vector3 defaultPosition;
   
    private void Start()
    {
        defaultPosition = coin.transform.position;
        checkCollision = true;
    }
    public void SendSignal()
    {
        if (checkCollision)
        {
            checkCollision = !checkCollision;
            if(typeCoin == TypeCoin.MCoin)
            {
                GameObject.FindWithTag("Player").GetComponent<MyWallet>().AddMCoin(coinFig.amountMCoinPerCoin);
            }
            else
            {
                GameObject.FindWithTag("Player").GetComponent<MyWallet>().AddVCoin(coinFig.amountVCoinPerCoin);
            }
            FindObjectOfType<CoinController>().SendSignalToCoinController(defaultPosition);
            Destroy(coin);
        }
    }
}
