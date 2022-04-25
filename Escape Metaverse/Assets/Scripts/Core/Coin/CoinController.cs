using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using EnumMetaverse;

public class CoinController : MonoBehaviour
{
    [SerializeField] GameObject MCoin;
    [SerializeField] GameObject VCoin;
    [SerializeField] GameObject placeToSpawn;


    public void SendSignalToCoinController( Vector3 newPosition , TypeCoin typeCoin)
    {
        StartCoroutine(WaitAndSpawnCoin(newPosition, typeCoin));
    }

    IEnumerator WaitAndSpawnCoin(Vector3 position, TypeCoin typeCoin)
    {
       yield return new WaitForSeconds(10f);
        if(typeCoin == TypeCoin.MCoin)
        {
            var tmp = Instantiate(MCoin, position, Quaternion.identity);
            tmp.transform.SetParent(placeToSpawn.transform);
        }
        else if(typeCoin == TypeCoin.VCoin)
        {
            var tmp = Instantiate(VCoin, position, Quaternion.identity);
            tmp.transform.SetParent(placeToSpawn.transform);
        }
    }
}
