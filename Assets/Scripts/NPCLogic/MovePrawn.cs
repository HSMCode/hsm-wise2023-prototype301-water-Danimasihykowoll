using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePrawn : MonoBehaviour
{
    /*variable for the prawn*/
    public GameObject prawn;

    /* variable for the up and left movement of the prawn*/
    public float speed = -1f;

    // Update is called once per frame
    void Update()
    {
        /*to make the move*/
        prawn.transform.Translate(speed * Time.deltaTime, 0, 0, Space.World);
    }
}
