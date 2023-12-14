using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Restart : MonoBehaviour
{
    //variable for GameOver screen
    public GameObject gameOverScreen;
    
    //function for restart the game
    public void restartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    //function for gameOver
    public void gameOver()
    {
        gameOverScreen.SetActive(true);
    }
}
