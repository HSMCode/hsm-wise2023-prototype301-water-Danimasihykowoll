using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveNPC2 : MonoBehaviour
{
    /*variable for the NPC*/
    public GameObject NPC;

    /* variable for the movement of the NPC*/
    public float speed = 2f;

    /*variable for the position of the NPC*/
    public float y_coordinate;


    // Update is called once per frame
    void Update()
    {
        /*to make the move*/
        NPC.transform.Translate(speed*Time.deltaTime,0,0);
        
         /* Something that I tried but didn't work
         if (Player.transform.Translate(10,0,0))
         {
             speed = -2f;
         }
         Debug.Log(Player.transform.position.x);
         */

        /*saving the x coordinate position player into the position variable*/
        y_coordinate = NPC.transform.position.y;

        /*conditional of the movement, to keep moving the NPC into -3 and 3 in the x axis*/
        if (y_coordinate>=0f || y_coordinate<=6f){
            speed = speed*-1f;
        }
    }
}
