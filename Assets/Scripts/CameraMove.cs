using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMove : MonoBehaviour
{
    /*variable for the Game Object*/
    public GameObject cameraObject;

    public float speed = -2f;

    /*variable for the position of the NPC*/
    public float x_coordinate;

    // Update is called once per frame
    void Update()
    {
        /*to make the move*/
        cameraObject.transform.Translate(speed*Time.deltaTime,0,0);

        /*saving the x coordinate position player into the position variable*/
        x_coordinate = cameraObject.transform.position.x;

        /*conditional of the movement, to keep moving the NPC into -3 and 3 in the x axis*/
        if (x_coordinate<=0f){
            speed = 0f;
        }
    }
}

