using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveDuck : MonoBehaviour
{
    /*variable for the Game Object*/
    public GameObject Player;

    /*variable for the speed going up and down of the Game Object*/
    public float up = 20f; 
    public float down = 0.5f; 

    // Update is called once per frame
    void Start()
    {

    }

    void Update()
    {

        if(Input.GetKeyDown("space"))
        {
            /* to move up the Game Object pressing space*/
            Player.transform.Translate(Vector3.up*up*Time.deltaTime, Space.World);

        }  

       if(Input.GetKey("space"))
        {
            /* to move down the Game Object pressing space*/
        Player.transform.Translate(Vector3.up*down*-Time.deltaTime, Space.World);
      
        }
    }
}
