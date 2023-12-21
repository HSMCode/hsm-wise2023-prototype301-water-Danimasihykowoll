using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InvokeBigPrawn : MonoBehaviour
{
    //variable for the counter
    private EatingPrawns counter;

    //variable for the script "EatingPrawns"
    public EatingPrawns EatingPrawns;

    //variable for gameObject BigPrawn
     public GameObject BigP;

     //variable for the speed in y
    public float speed = 1f;

    //variable for the speed in x
    public float speed2 = 0.3f;

  
    // Start is called before the first frame update
    void Start()
    {
        //to call the variable counter from the script EatingPrawns
        counter = GameObject.Find("Duck").GetComponent<EatingPrawns>();

    }

    // Update is called once per frame
    void Update()
    {
        //calling the void SomeMethod
            SomeMethod();
        
    }

    void SomeMethod()
    {
      //when counter is 10 appears the BigPrawn from the right up side of the screen moving to the left down side
      if(counter.counter>=10f)
      {

        BigP.transform.Translate(0,speed*-Time.deltaTime,speed2*Time.deltaTime);
        
      }
    }
}