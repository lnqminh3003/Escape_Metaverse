using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attack : MonoBehaviour
{
    [SerializeField] GameObject rightHand;

    private void Update()
    {
        if(Input.GetKeyDown("space"))
        {
            if(rightHand.transform.childCount >0)
            {
                var weapon = rightHand.transform.GetChild(0);
                if(weapon.GetComponent<Gun>())
                {
                    weapon.GetComponent<Gun>().Fire();
                }
            }
        }
    }
}
