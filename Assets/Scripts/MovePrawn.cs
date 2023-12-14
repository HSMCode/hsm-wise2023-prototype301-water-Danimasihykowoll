using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePrawn : MonoBehaviour
{
    /*variable for the prawn*/
    public GameObject prawn;

    /* variable for the up and left movement of the prawn*/
    public float speed = 1f;
    public float speed2 = 0.3f;

    // Update is called once per frame
    void Update()
    {
        /*to make the move*/
        prawn.transform.Translate(0,speed*Time.deltaTime,speed2*Time.deltaTime);
    }
}
