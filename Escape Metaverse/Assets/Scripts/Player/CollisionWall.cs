using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionWall : MonoBehaviour
{
    ControlMove controlMove;

    private void Start()
    {
        controlMove =GameObject.FindWithTag("Player").GetComponent<ControlMove>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Wall")
        {
            controlMove.ChangeSpeed(0);
            controlMove.ChangeVectorTmp(transform.forward.normalized);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Wall")
        {
            controlMove.ChangeSpeed(controlMove.GetSpeed());
            controlMove.ChangeVectorTmp(transform.forward.normalized);
        }
    }
}
