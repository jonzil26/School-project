﻿
using UnityEngine;
using UnityEngine.UI;

public class score : MonoBehaviour
{
    // Start is called before the first frame update
    public Transform player;
    public Text pointsText;


    // Update is called once per frame
    void Update()
    {
        //Debug.Log(player.position.x);
        pointsText.text = ("points:  ") + player.position.x.ToString("0");
    }
}
