using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class PlayerScore : MonoBehaviour
{
    public Transform player;
    public Text score;
    public PlayerMovement PM;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if(PM.start == true)
        {
            score.text = "Your Score is:" + Convert.ToInt32(player.position.z + 1).ToString();
        }

        else
        {
            score.text = "Press SPACE to start the game.\n Use D & A to control the ball";
        }
    }
}
