using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InvokeTucanPartner1 : MonoBehaviour
{
    //variable for the counter
    private EatingMango counter;

    //variable for the script "EatingMango"
    public EatingMango EatingMango;

    //variable for gameObject Tucan Partner
     public GameObject TucanP;

     //variable for the Tucan Partners speed
     public float speed = 2f;

     public Restart logic2;
    // Start is called before the first frame update
    void Start()
    {
        //to call the variable counter from the script EatingMango
        counter = GameObject.Find("Toucan").GetComponent<EatingMango>();

        //to call logic2 from the script Restart
        logic2 = GameObject.FindGameObjectWithTag("Logic2").GetComponent<Restart>();
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
      if(counter.counter==50f)
      {
        Debug.Log("The variable value accessed from the other script" + counter.counter);
        Vector3 posOriginal = transform.position;
        TucanP.transform.Translate(speed*Time.deltaTime,0,0);
        logic2.gameOver();
      }
    }
}