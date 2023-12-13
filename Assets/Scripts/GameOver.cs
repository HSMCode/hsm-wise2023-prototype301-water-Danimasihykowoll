using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOver : MonoBehaviour
{
    //variable for the gameObject logic
    public Restart logic;

    // Start is called before the first frame update
    void Start()
    {
        //to call the gameObject tagged logic with the script Restart
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<Restart>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //to put a game over screen when tucan touches a cobra
     private void OnCollisionEnter(Collision collision)
    {
        
        
        //when a cobra touches another gameObject with the tag Player
        if (collision.gameObject.CompareTag("Player"))
        {
           
            // Destroy the Player
            Destroy(collision.gameObject);

            Debug.Log(" Game Over " + collision.gameObject.name);

            //to put the Game Over screen
            logic.gameOver();

        }
    }
}
