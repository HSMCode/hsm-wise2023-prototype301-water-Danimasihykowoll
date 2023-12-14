using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InvokePiranha2 : MonoBehaviour
{

    public GameObject objectToSpawn;
    public Vector3 offset;


    // Start is called before the first frame update
    void Start()
    {

       //Invokes the method after given time and repeats this every time defined
       InvokeRepeating("SpawnMoreObjects", 27.0f, 7f);
    
    }

    // Update is called once per frame
    void Update()
    {
   
    }

    void SpawnMoreObjects()
    {
    
      GameObject spawnedObject = Instantiate(objectToSpawn, transform.position+offset, transform.rotation);
     
    }
}