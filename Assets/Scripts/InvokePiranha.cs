using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InvokePiranha : MonoBehaviour
{

    public GameObject objectToSpawn;
    public Vector3 offset;


    // Start is called before the first frame update
    void Start()
    {

       // Invoke the method one time after the given time

        //Invoke("SpawnMoreObjects", 2.0f);

       //Invokes the method after given time and repeats this every time defined
       InvokeRepeating("SpawnMoreObjects", 30.0f, 8f);

       //Call the custom method defined below
       // SpawnMoreObjects();   
       
    }

    // Update is called once per frame
    void Update()
    {
       // Instantiate(objectToSpawn, (transform.position+offset), transform.rotation);
    }

    void SpawnMoreObjects()
    {
     
        
        GameObject spawnedObject = Instantiate(objectToSpawn, transform.position+offset, transform.rotation);
      //  transform.position= new Vector3(transform.position.x, transform.position.y,transform.position.z);

       
    }
}