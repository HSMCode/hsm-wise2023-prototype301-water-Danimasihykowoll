using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InvokeOwl : MonoBehaviour
{

    public GameObject objectToSpawn;
    public Vector3 offset;
    public float minY = 1.2f;
    public float maxY = 3.7f;
    private float newY;

    // Start is called before the first frame update
    void Start()
    {

       //Invokes the method after given time and repeats this every time defined
       InvokeRepeating("SpawnMoreObjects", 5.0f, 3f);

    }

    // Update is called once per frame
    void Update()
    {
      
    }

    void SpawnMoreObjects()
    {
        newY = Random.Range(minY, maxY);
        Vector3 offset = new Vector3(0, newY, 0);
        GameObject spawnedObject = Instantiate(objectToSpawn, transform.position+offset, transform.rotation);
   
    }
}