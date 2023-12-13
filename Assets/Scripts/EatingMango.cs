using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class EatingMango : MonoBehaviour
{
    //Variable for text (amount of mangos)
    public TMP_Text mangoText;

    //Variable for the counter
    public float counter = 0f;

    // Start is called before the first frame update
    void Start()
    {
        //to write the counter beginning in 0/50
        mangoText.text = counter.ToString() + "/50";
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //When tucan collides with a mango the counter adds 1
     private void OnCollisionEnter(Collision collision)
    {
     
        //when the player touches another gameObject with the tag Mango
        if (collision.gameObject.CompareTag("Mango"))
        {
            //to put a message every time the player collides with a mango
            Debug.Log("Ñamñam! Mangos: " + counter);
            
            
            // Destroy the mango
            Destroy(collision.gameObject);

            //counter adds 1
            counter = counter + 1f;

            //to update the counter in the text
             mangoText.text = counter.ToString() + "/50";
        } 
    }
}
