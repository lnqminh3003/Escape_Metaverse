using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using EnumMetaverse;

public class Attack : MonoBehaviour
{
    [SerializeField] GameObject rightHand;

    ProjectileController projectileController;

    private void Start()
    {
        projectileController = FindObjectOfType<ProjectileController>();
    }

    private void Update()
    {
        if(Input.GetKeyDown("space"))
        {
            if(rightHand.transform.childCount >0)
            {
                var weapon = rightHand.transform.GetChild(0);
                if (projectileController.HaveBullet())
                {
                    weapon.GetComponent<Gun>().Fire();
                    projectileController.DecreaseProjectile();
                }
            }
        }
    }
}
