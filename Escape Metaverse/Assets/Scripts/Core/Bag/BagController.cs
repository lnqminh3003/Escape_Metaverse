using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BagController : MonoBehaviour
{
    [SerializeField] BagUI bagUI;
    MyBag myBag;
    bool isBagActive;

    private void Awake()
    {
        myBag = FindObjectOfType<MyBag>();

        if (bagUI == null || myBag == null) return;
        isBagActive = false;
    }

    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.B))
        {
            if(!isBagActive)
            {
                DisplayBag();
            }
            else
            {
                ExitBag();
            }
        }
    }

    //button Display
    public void DisplayBag()
    {
        if (bagUI == null || myBag == null) return;

        bagUI.gameObject.SetActive(true);
        isBagActive = true;
        bagUI.SetItems(myBag.GetBagItems());
    }

    //button Exit
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
