using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyWallet : MonoBehaviour
{
    //MCoin -> buy Weapon
    //VCoin -> buy Material
    [SerializeField] int MCoin;
    [SerializeField] int VCoin;

    private void Start()
    {
        MCoin = 0;
        VCoin = 0;
    }

    public void AddMCoin(int point)
    {
        MCoin += point;
    }

    public void AddVCoin(int point)
    {
        VCoin += point;
    }

}
