using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveNPC : MonoBehaviour
{
    /*variable for the NPC*/
    public GameObject NPC;

    /* variable for the movement of the NPC*/
    public float speed = -1f;

    // Update is called once per frame
    void Update()
    {
        /*to make the move*/
        NPC.transform.Translate(speed * Time.deltaTime, 0, 0, Space.World);
    }
}
