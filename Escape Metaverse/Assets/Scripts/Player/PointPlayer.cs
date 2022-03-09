using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PointPlayer : MonoBehaviour
{
    [SerializeField] int pointMoney;
    [SerializeField] int pointSkill;
    private void Start()
    {
        pointMoney = 0;
        pointSkill = 0;
    }

    public void AddPointMoney(int point)
    {
        this.pointMoney += point;
    }

    public int GetPointMoney()
    {
        return pointMoney;
    }

    public void AddPointSkill(int point)
    {
        this.pointSkill += point;
    }

    public int GetPointSkill ()
    {
        return pointSkill;
    }
}
