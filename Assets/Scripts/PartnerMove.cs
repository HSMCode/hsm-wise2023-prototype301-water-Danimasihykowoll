using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PartnerMove : MonoBehaviour
{
    /*variable for the Game Object*/
    public GameObject Partner;

    public float speed = -2f;

    ////public float rotationVelocity = 180f;
    //public float x_coordinate;

    // Update is called once per frame
    void Start(){
       

    }

    void Update()
    {
      Partner.transform.Translate(Vector3.right*speed*Time.deltaTime, Space.World);
      

  
    }
}
