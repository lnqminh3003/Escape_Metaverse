using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponController : MonoBehaviour
{
    [SerializeField] GameObject rightHand;

    public void SpawnGun(Item item)
    {
        if(rightHand.transform.childCount >0)
        {
            Destroy(rightHand.transform.GetChild(0).gameObject);
        } 
        var tmp =Instantiate(item.gameObject, rightHand.transform);
        tmp.transform.parent= rightHand.transform;
    }
}
