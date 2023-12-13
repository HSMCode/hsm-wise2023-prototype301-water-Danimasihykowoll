using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Win : MonoBehaviour
{


    // Start is called before the first frame update
    void Start()
    {
  
    }

    // Update is called once per frame
    void Update()
    {
        
    }


     private void OnCollisionEnter(Collision collision)
    {
        
        
        //when the player touches another gameObject with the tag NPC
        if (collision.gameObject.CompareTag("Partner"))
        {
            Debug.Log(" There's my partner!");
        
            // Destroy the NPC GameObject
            Destroy(gameObject);
            Destroy(collision.gameObject);


            //to put a message every time the player collides with the NPCs
        
        }
    }
}

