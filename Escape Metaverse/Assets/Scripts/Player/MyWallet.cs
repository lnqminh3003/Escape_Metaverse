using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyWallet : MonoBehaviour
{
    //MCoin -> buy Weapon
    //VCoin -> buy Material
    public int MCoin;
    public int VCoin;

    DisplayCoin coinController;

    private void Start()
    {
        coinController = FindObjectOfType<DisplayCoin>();
        coinController.DisplayCoinToUI(MCoin, VCoin);
    }

    public void AddMCoin(int point)
    {
        MCoin += point;
        coinController.DisplayCoinToUI(MCoin, VCoin);
    }

    public void AddVCoin(int point)
    {
        VCoin += point;
        coinController.DisplayCoinToUI(MCoin, VCoin);
    }

    public void SpendMCoin(int amount)
    {
        MCoin -= amount;
        coinController.DisplayCoinToUI(MCoin, VCoin);
    }
    public void SpendVCoin(int amount)
    {
        VCoin -= amount;
        coinController.DisplayCoinToUI(MCoin, VCoin);
    }

}
