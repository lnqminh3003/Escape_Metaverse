using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Elevator : MonoBehaviour
{
    [SerializeField] float speed;
    [SerializeField] float limitUp;
    [SerializeField] float limitDown;

    ControlMove player;
    bool canMoveUp = false;
    bool canMoveDown = false;
    Vector3 defaultPosition;

    private void Start()
    {
        player = FindObjectOfType<ControlMove>();
        defaultPosition = transform.position;
    }

    private void Update()
    {
        ElevatorMove();
    }

    private void ElevatorMove()
    {
        if (canMoveUp)
        {
            player.TranslatePlayer(new Vector3(0, 1, 0), speed);
            transform.Translate(new Vector3(0, 1, 0) * speed * Time.deltaTime, Space.World);
            if (transform.position.y - limitUp >= Mathf.Epsilon)
            {
                canMoveUp = false;
                GetComponent<Rigidbody>().isKinematic = true;

            }
        }

        if (canMoveDown)
        {
            transform.position = Vector3.MoveTowards(transform.position, defaultPosition, speed * Time.deltaTime);
            if (transform.position.x == defaultPosition.x && transform.position.y == defaultPosition.y
                && transform.position.z == defaultPosition.z)
            {
                canMoveDown = false;
            }
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag =="Foot")
        {
            GetComponent<Rigidbody>().isKinematic = false;
            canMoveUp = true;
            canMoveDown = false;
        }
    }

    private void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.tag == "Foot")
        {
            if(transform.position.y - limitUp >= Mathf.Epsilon)
            {
                StartCoroutine(WaitElevatorMoveDown());
            }
            else
            {
                GetComponent<Rigidbody>().isKinematic = false;
                canMoveDown = true;
                canMoveUp = false;
            }
        }
    }

    IEnumerator WaitElevatorMoveDown()
    {
        yield return new WaitForSeconds(3f);
        GetComponent<Rigidbody>().isKinematic = false;
        canMoveDown = true;
        canMoveUp = false;
    }
}
