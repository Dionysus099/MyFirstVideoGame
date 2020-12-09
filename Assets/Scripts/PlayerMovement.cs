using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody prb;
    public float forward_force = 1000f;
    public float side_force = 50f;
    public bool start = false;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if(Input.GetKey("space"))
        {
            start = true;
        }

        if(start == true)
        {
            prb.AddForce(0, 0, forward_force * Time.deltaTime);        

            if(Input.GetKey("d"))
            {
                prb.AddForce(side_force * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
            }

            if(Input.GetKey("a"))
            {
                prb.AddForce(-side_force * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
            }

            if(prb.position.y <= 312f)
            {
                FindObjectOfType<NewGM>().GameOver();
            }
        }       
    }
}
