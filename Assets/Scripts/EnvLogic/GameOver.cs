using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{

    private bool gameOver = false;

    //variable for the GameOver/restart screen
    public Restart logic;

    // Start is called before the first frame update
    void Start()
    {
        //to call the gameObject tagged logic with the script Restart
       logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<Restart>();
        gameOver = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (gameOver == true && Input.GetKeyDown("space"))
        {
            SceneManager.LoadScene("water");
        }
    }

    //to put a gameover screen when the duck touches a piranha or owl
     private void OnCollisionEnter(Collision collision)
    {
        
        
        //when a piranha/owl touches another gameObject with the tag Player
        if (collision.gameObject.CompareTag("Player"))
        {
           
            // Destroy the Player
            Destroy(collision.gameObject);


            //to put the GameOver screen
            logic.gameOver();

            gameOver = true;

        }
    }
}
