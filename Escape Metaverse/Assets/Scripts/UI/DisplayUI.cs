using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class DisplayUI : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI pointMoneyText;
    [SerializeField] TextMeshProUGUI pointSkillText;

    GameObject player;
    private void Start()
    {
        player = GameObject.FindWithTag("Player"); 
    }
    private void Update()
    {
        pointMoneyText.text = player.GetComponent<PointPlayer>().GetPointMoney().ToString();
        pointSkillText.text = player.GetComponent<PointPlayer>().GetPointMoney().ToString();
    }
}
