using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveBigPrawn : MonoBehaviour
{
    /*variable for the NPC*/
    public GameObject prawn;

    /* variable for the movement of the NPC*/
    public float speed = 1f;
    public float speed2 = 0.3f;

    // Update is called once per frame
    void Update()
    {
        /*to make the move*/
        prawn.transform.Translate(0,speed*-Time.deltaTime,speed2*Time.deltaTime);
    }
}
