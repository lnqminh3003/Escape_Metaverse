using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class EnemyProjectile : MonoBehaviour
{
    float speed;
    int damage;
    GameObject effect;
    bool getDirection = false;
    HealthPlayer healthPlayer;
   
    private void Start()
    {
        healthPlayer = FindObjectOfType<HealthPlayer>();
    }

    private void Update()
    {
        if (!getDirection) return;
        Fire();
    }

    public void setFeature(GameObject target, GameObject effect, float speed,int damage)
    {
        transform.LookAt(target.transform);
        this.effect = effect;
        this.speed = speed;
        this.damage = damage;

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
            Destroy(gameObject);
        }
    }
}
