using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BagController : MonoBehaviour
{
    BagUI bagUI;
    MyBag myBag;
    bool isBagActive;

    private void Awake()
    {
        bagUI = FindObjectOfType<BagUI>();
        myBag = FindObjectOfType<MyBag>();

        if (bagUI == null || myBag == null) return;
        isBagActive = false;
        bagUI.gameObject.SetActive(false);
    }

    public void DisplayBag()
    {
        if (bagUI == null || myBag == null) return;

        bagUI.gameObject.SetActive(true);
        isBagActive = true;
        bagUI.SetItems(myBag.GetBagItems());
    }

    public void ExitBag()
    {
        if (bagUI == null || myBag == null) return;

        bagUI.gameObject.SetActive(false);
        isBagActive = false;
    }

    public bool IsBagActive()
    {
        return isBagActive;
    }
}
