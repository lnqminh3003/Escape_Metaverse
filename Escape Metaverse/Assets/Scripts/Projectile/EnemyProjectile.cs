using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Meta.Enum;

public class EnemyProjectile : MonoBehaviour
{
    [SerializeField] float speed;
    [SerializeField] int damage;

    bool getDirection = false;
    HealthPlayer healthPlayer;
    GameObject effect;

    private void Start()
    {
        healthPlayer = FindObjectOfType<HealthPlayer>();
    }

    private void Update()
    {
        if (!getDirection) return;
        Fire();
    }

    public void setDirection(GameObject target, GameObject effect)
    {
        transform.LookAt(target.transform);
        this.effect = effect;
        getDirection = true;
    }

    private void Fire()
    {
        transform.Translate(Vector3.forward * speed * Time.deltaTime); 
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.name == "Player")
        {
            healthPlayer.DamagePlayer(damage);
            Instantiate(effect, gameObject.transform.position, Quaternion.identity);
        }
    }
}
