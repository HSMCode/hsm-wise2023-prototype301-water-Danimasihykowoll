using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InvokePiranha : MonoBehaviour
{

    public GameObject objectToSpawn;
    private Vector3 offset;
    public float minY = -1.6f;
    public float maxY = 1.2f;
    private float newY;

    // Start is called before the first frame update
    void Start()
    {

        //Invokes the method after given time and repeats this every time defined
        InvokeRepeating("SpawnMoreObjects", 1.0f, 2f);

    }

    // Update is called once per frame
    void Update()
    {

    }

    void SpawnMoreObjects()
    {
        newY = Random.Range(minY, maxY);
        Vector3 offset = new Vector3(0, newY, 0);
        GameObject spawnedObject = Instantiate(objectToSpawn, transform.position + offset, transform.rotation);
    }
}