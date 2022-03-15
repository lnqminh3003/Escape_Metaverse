using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyWallet : MonoBehaviour
{
    //coin01 -> buy Material
    //coin02 -> buy weapon
    [SerializeField] int coin01;
    [SerializeField] int coin02;

    private void Start()
    {
        coin01 = 0;
        coin02 = 0;
    }

    public void AddCoin01(int point)
    {
        coin01 += point;
    }

    public void AddCoin02(int point)
    {
        coin02 += point;
    }

}
