using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveDuck : MonoBehaviour
{
    /*variable for the Game Object*/
    public GameObject Player;
    Rigidbody _rb;

    /*variable for the speed going up and down of the Game Object*/
    public float speed = -0.2f;
    public float returnspeed = 0.1f;
    private float currentY;
    private float storeSpeed;
    private Vector3 stopSign = new Vector3(0, 0, 0);

    // Update is called once per frame
    void Start()
    {
        _rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        if (EatingPrawns.win == false)
        {
            currentY = transform.position.y;
            if (Input.GetKey("space"))
            {
                if (currentY >= -1.4f)
                {
                    transform.position += new Vector3(0, -0.04f, 0);
                }
            }

            else if (currentY <= 3.5f)
            {
                transform.position += new Vector3(0, 0.03f, 0);
            }
        }
       // if(Input.GetKeyDown("space"))
       // {
       //     /* to move up the Game Object pressing space*/
       //     Player.transform.Translate(Vector3.up*up*Time.deltaTime, Space.World);

       // }  

       //if(Input.GetKey("space"))
       // {
       //     /* to move down the Game Object pressing space*/
       // Player.transform.Translate(Vector3.up*down*-Time.deltaTime, Space.World);
      
       // }
    }
    void Dive()
    {
        _rb.AddForce(0, speed, 0, ForceMode.VelocityChange);
    }
}
