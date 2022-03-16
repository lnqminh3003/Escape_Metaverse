using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinController : MonoBehaviour
{
    [SerializeField] GameObject coin;
    [SerializeField] GameObject placeToSpawn;


    public void SendSignalToCoinController( Vector3 newPosition)
    {
        StartCoroutine(WaitAndSpawnCoin(newPosition));
    }

    IEnumerator WaitAndSpawnCoin(Vector3 position)
    {
        yield return new WaitForSeconds(10f);
       var tmp = Instantiate(coin, position,Quaternion.identity);
        tmp.transform.SetParent(placeToSpawn.transform);
    }

}
