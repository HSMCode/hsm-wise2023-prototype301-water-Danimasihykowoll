using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InvokeBigPrawn : MonoBehaviour
{
    //variable for the counter
    private EatingPrawns counter;

    //variable for the script "EatingPrawns"
    public EatingPrawns EatingPrawns;

    //variable for gameObject Tucan Partner
     public GameObject BigP;

     //variable for the Tucan Partners speed
     
    public float speed = 1f;
    public float speed2 = 0.3f;

    // public Restart logic2;
    // Start is called before the first frame update
    void Start()
    {
        //to call the variable counter from the script EatingPrawns
        counter = GameObject.Find("Duck").GetComponent<EatingPrawns>();

        //to call logic2 from the script Restart
      //  logic2 = GameObject.FindGameObjectWithTag("Logic2").GetComponent<Restart>();
    }

    // Update is called once per frame
    void Update()
    {
        //calling the void SomeMethod
            SomeMethod();
        
    }

    void SomeMethod()
    {
      //when counter is 50 appears the tucan partner from the right side of the screen moving to the left side
      if(counter.counter==10f)
      {
        BigP.transform.Translate(0,speed*-Time.deltaTime,speed2*Time.deltaTime);
   //     logic2.gameOver();
      }
    }
}