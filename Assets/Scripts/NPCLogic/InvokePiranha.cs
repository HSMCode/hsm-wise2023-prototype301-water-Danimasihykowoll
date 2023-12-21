using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InvokePiranha : MonoBehaviour
{

    public GameObject objectToSpawn;
    private Vector3 offset;
    public int minY = -2;
    public int maxY = 1;
    private int newY;

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
        GameObject spawnedObject = Instantiate(objectToSpawn, transform.position + offset, Quaternion.identity);
    }
}