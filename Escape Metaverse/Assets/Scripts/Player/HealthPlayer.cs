using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthPlayer : MonoBehaviour
{
    [Header("Info Health")]
    public int blood;
    public int food;
    public int run;

    [Header("Max Health")]
    public int maxBlood ;
    public int maxFood;
    public int maxRun;


    public void ChangeBlood(int damage , bool signal )
    {
        if(signal)
        {
            blood += damage;
            if(blood >= maxBlood)
            {
                blood = maxBlood;
            }
            return;
        }

        blood -= damage;
        if(blood <=0)
        {
            Debug.Log("DIE");
        }
    }
    public void ChangeFood(int damage , bool signal )
    {
        if(signal)
        {
            food += damage;
            if(food >= maxFood)
            {
                food = maxFood;
            }
            return;
        }
        
        food -= damage;
        if(food <=0)
        {
            Debug.Log("DIE");
        }
    }
    public void ChangeRun(int damage , bool signal )
    {
        if(signal)
        {
            run += damage;
            if(run >= maxRun)
            {
                run = maxRun;
            }
            return;
        }
        
        run -= damage;
        if(run <=0)
        {
            Debug.Log("DIE");
        }
    }
}
