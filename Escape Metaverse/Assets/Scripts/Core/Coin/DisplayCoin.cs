using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class DisplayCoin : MonoBehaviour
{
    [Header("Coin")]
    [SerializeField] TextMeshProUGUI MCoinText;
    [SerializeField] TextMeshProUGUI VCoinText;

    public void DisplayCoinToUI(int MCoin, int VCoin)
    {
        MCoinText.text = MCoin.ToString();
        VCoinText.text = VCoin.ToString();
    }
}
