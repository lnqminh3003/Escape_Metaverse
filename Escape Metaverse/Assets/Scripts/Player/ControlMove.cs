using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class ControlMove : MonoBehaviour
{
    [SerializeField] float speed;

    float currentSpeed;
    bool canMove = true;
    BagController bagController;
    Vector3 tmp;

    private void Start()
    {
        currentSpeed = speed;     
        bagController = FindObjectOfType<BagController>();
    }
    private void Update()
    {
        
        if (canMove /*&& !bagController.IsBagActive()*/)
        {
            Move();
        }
    }
    private void Move()
    {
        float getX = Input.GetAxisRaw("Horizontal");
        float getZ = Input.GetAxisRaw("Vertical");

        if (getX != 0)
        {
            TranslatePlayer(new Vector3(getX, 0, 0), currentSpeed);

            transform.forward = new Vector3(getX, 0, 0);
            if (tmp == -transform.forward.normalized)
            {
                currentSpeed = speed;
            }
            return;
        }
        if (getZ != 0)
        {
            TranslatePlayer(new Vector3(0,0,getZ) , currentSpeed);
 
            transform.forward = new Vector3(0, 0, getZ);
            if (tmp == -transform.forward.normalized)
            {
                currentSpeed = speed;
            }
        }
    }

    public void TranslatePlayer(Vector3 direction, float speed)
    {
        transform.Translate(direction * speed * Time.deltaTime, Space.World);
    }

    public float GetSpeed()
    {
        return speed;
    }

    public void ChangeSpeed(float speed)
    {
        currentSpeed = speed;
    }

    public void ChangeVectorTmp(Vector3 tmp)
    {
        this.tmp = tmp;
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Terrian")
        {
            canMove = true;
        }
    }

    private void OnCollisionExit(Collision collision)
    {
        if(collision.gameObject.tag =="Wall")
        {
           
        }
    }


}
