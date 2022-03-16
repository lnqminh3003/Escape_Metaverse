using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using EnumMetaverse;

public class BagItem : MonoBehaviour
{
     Item item;
   
    public void SetItem(Item item)
    {
        this.item = item;
    }

    public void PressButton()
    {
        if(item != null)
        {
            if(item.GetTypeItem() == TypeItem.gun)
            {
                FindObjectOfType<WeaponController>().SpawnGun(item);
            }
        }
    }
}
