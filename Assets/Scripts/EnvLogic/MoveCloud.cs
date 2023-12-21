using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCloud : MonoBehaviour
{
    /*variable for the cloud*/
    public GameObject Cloud;

    /* variable for the movement of the cloud*/
    public float speed = 1f;

    // Update is called once per frame
    void Update()
    {
        /*to make the move in the x coordinate*/
        Cloud.transform.Translate(speed*Time.deltaTime,0,0);
    }
}
