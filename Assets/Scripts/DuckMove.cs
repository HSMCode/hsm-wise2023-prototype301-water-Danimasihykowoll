using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DuckMove : MonoBehaviour
{
    /*variable for the Game Object*/
    public GameObject Player;

    /*variable for the movement of the Game Object*/
    public float up = 20f; 
    public float down = 0.5f; 

    public float speed = 20f;

    public float speed2 = 2f;

    // Update is called once per frame
    void Start()
    {

    }

    void Update()
    {
         Vector3 positionOriginal = transform.position;

       // Player.transform.Translate(0,0,speed*Time.deltaTime);

        if(Input.GetKeyDown("space"))
        {
            /* to move up the Game Object pressing space*/
            Player.transform.Translate(Vector3.up*up*Time.deltaTime, Space.World);

        }  

       if(Input.GetKey("space"))
        {

        Player.transform.Translate(Vector3.up*down*Time.deltaTime, Space.World);
      
        }
    }
}
