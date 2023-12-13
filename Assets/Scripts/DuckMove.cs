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
        {
          //  Player.transform.Translate(Vector3.right*(up), Space.World);
        }  
        
        //Player.transform.Translate(speed2*Time.deltaTime,0,0);

         //x_coordinate = Player.transform.position.x;

       
         //Player.transform.Translate(Vector3.right*speed2, Space.World);
       // if (x_coordinate == 0f)
      //{
        // speed2 = speed2*0f;
      //}
         Vector3 positionOriginal = transform.position;

        Player.transform.Translate(0,0,speed*Time.deltaTime);

        if(Input.GetKeyDown("space"))
        {
            /* to move up the Game Object pressing space*/
            Player.transform.Translate(Vector3.up*up*10*Time.deltaTime, Space.World);

            /* to return it to the original position also pressing space*/
           // jumpHeight = jumpHeight*-1;
        }  

       if(Input.GetKey("space"))
        {

        Player.transform.Translate(Vector3.up*down*Time.deltaTime, Space.World);
       //// float rotation = rotationVelocity * Time.deltaTime;
       //// transform.Rotate(Vector3.left * rotationVelocity);
        //Player.transform.Rotate(0.0f, 0.0f, rotationVelocity, Space.World);
       // Player.transform.Rotate(Vector3.up * rotationVelocity, Space.World);
        }
        
        ////transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.identity, Time.deltaTime);
        ////transform.position = new Vector3(positionOriginal.x, transform.position.y, positionOriginal.z);

    }
}
