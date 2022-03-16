using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    [SerializeField] GameObject coin;
    [SerializeField] int point;

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
            GameObject.FindWithTag("Player").GetComponent<MyWallet>().AddCoin01(point);
            FindObjectOfType<CoinController>().SendSignalToCoinController(defaultPosition);
            Destroy(coin);
        }
    }
}
