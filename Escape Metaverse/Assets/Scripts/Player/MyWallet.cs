using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyWallet : MonoBehaviour
{
    //MCoin -> buy Weapon
    //VCoin -> buy Material
    [SerializeField] int MCoin;
    [SerializeField] int VCoin;

    DisplayCoin coinController;

    private void Start()
    {
        MCoin = 0;
        VCoin = 0;

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

}
