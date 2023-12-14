using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMove : MonoBehaviour
{
    /*variable for the camera*/
    public GameObject cameraObject;

    //variable for the speed 
    public float speed = -2f;

    /*variable for the position of the camera in the x coordinate*/
    public float x_coordinate;

    // Update is called once per frame
    void Update()
    {
        /*to make the move in the x coordinate*/
        cameraObject.transform.Translate(speed*Time.deltaTime,0,0);

        /*saving the x coordinate position into the position variable*/
        x_coordinate = cameraObject.transform.position.x;

        /*conditional of the movement, to stop in x = 0*/
        if (x_coordinate<=0f){
            speed = 0f;
        }
    }
}

