using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameOverText : MonoBehaviour
{
    //variable for the text Game Over
    public TMP_Text GameOverTextt;

    // Start is called before the first frame update
    void Start()
    {
      //to not appear before a collision between the tucan and a cobra 
      GameOverTextt.text = "";
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //when the collision happens, Game Over Screen
     private void OnCollisionEnter(Collision collision)
    {
        
        
        //when a cobra touches the tucan
        if (collision.gameObject.CompareTag("Player"))
        {

            GameOverTextt.text = "GAME OVER";
            Debug.Log(" Game Over " + collision.gameObject.name);

            //to put a message every time the player collides with the NPCs

        }
    }
}

