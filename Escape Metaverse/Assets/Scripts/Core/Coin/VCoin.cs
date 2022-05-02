using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using EnumMetaverse;

public class VCoin : Coin
{
    public TypeCoin typeCoin;

    public override void SendSignal()
    {
        if (checkCollision)
        {
            checkCollision = !checkCollision;
            GameObject.FindWithTag("Player").GetComponent<MyWallet>().AddVCoin(coinFig.amountVCoinPerCoin);
            FindObjectOfType<CoinController>().SendSignalToCoinController(defaultPosition, typeCoin);
            Destroy(coin);
        }
    }
}
