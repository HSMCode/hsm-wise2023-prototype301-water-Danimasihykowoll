using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InvokePrawns : MonoBehaviour
{

    public GameObject objectToSpawn;
    public Vector3 offset;


    // Start is called before the first frame update
    void Start()
    {

       //Invokes the method after given time and repeats this every time defined
       InvokeRepeating("SpawnMoreObjects", 5.0f, 10f);
        InvokeRepeating("SpawnOffSet", 10.0f, 19f);
 
    }

    // Update is called once per frame
    void Update()
    {
   
    }

    void SpawnOffSet()
    {
        GameObject spawnedObject = Instantiate(objectToSpawn, transform.position + offset, transform.rotation);
    }

    void SpawnMoreObjects()
    {
      
      GameObject spawnedObject = Instantiate(objectToSpawn, transform.position, transform.rotation);
   
    }
}