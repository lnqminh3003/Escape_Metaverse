using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class DisplayProjectile : MonoBehaviour
{
    [Header("Gun")]
    [SerializeField] GameObject gunSprite;

    [Header("Projectile")]
    [SerializeField] TextMeshProUGUI numberProjectile;

    ProjectileController projectileController;
    bool first;

    private void Start()
    {
        projectileController = GetComponent<ProjectileController>();
        first = true;
    }

    private void Update()
    {
        if (first) return;
        numberProjectile.text = projectileController.GetNumberCurrentProjectile().ToString();
    }

    public void ChangeGun(Sprite spriteGun)
    {
        gunSprite.GetComponent<Image>().sprite = spriteGun;
        first = false;
    }
}
