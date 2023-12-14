using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCloud : MonoBehaviour
{
    /*variable for the NPC*/
    public GameObject Cloud;

    /* variable for the movement of the NPC*/
    public float speed = 1f;

    /*variable for the position of the NPC*/
    public float x_coordinate;


    // Update is called once per frame
    void Update()
    {
        /*to make the move*/
        Cloud.transform.Translate(speed*Time.deltaTime,0,0);
    }
}
