using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveMango : MonoBehaviour
{
    /*variable for the NPC*/
    public GameObject Mango;

    /* variable for the movement of the NPC*/
    public float speed = 2f;

    /*variable for the position of the NPC*/
    public float x_coordinate;


    // Update is called once per frame
    void Update()
    {
        /*to make the move*/
        Mango.transform.Translate(speed*-Time.deltaTime,0,0);
        
         /* Something that I tried but didn't work
         if (Player.transform.Translate(10,0,0))
         {
             speed = -2f;
         }
         Debug.Log(Player.transform.position.x);
         */
       
    }
}
