using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveDuck : MonoBehaviour
{
    /*variable for the Game Object*/
    Rigidbody rb;
    public float Tauchen = -1f;
    public float jumpForce = 0.5f;


    void Start()
    {
        rb = GetComponent<Rigidbody>();
        
    }

    void Update()
    {


        if (EatingPrawns.win == false)
        {
   
            if (Input.GetKey(KeyCode.Space) && gameObject.transform.position.y >= -1.4f)
            {
                  rb.velocity = new Vector3(rb.velocity.x, Tauchen, rb.velocity.z);

            }

            else if(gameObject.transform.position.y <= 3.5f)
                {
                    rb.velocity = new Vector3(rb.velocity.x, jumpForce, rb.velocity.z);
                     
                }

            else if(gameObject.transform.position.y >= 3.5f)
                {
                    rb.velocity = new Vector3(rb.velocity.x, 0f, rb.velocity.z);
            
                }
        }
    }
}