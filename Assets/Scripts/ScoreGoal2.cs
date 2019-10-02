using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreGoal2 : MonoBehaviour
{
    private int count2;

    // Use this for initialization
     void Start () {
        count2 = 0;
     }

        /*

     // Update is called once per frame
     void Update () {

     }*/


    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.name == "puck")
        {
            print("collided!");
            col.gameObject.transform.Translate(new Vector3(0, 0, -2.3f));
            col.gameObject.transform.Translate(new Vector3(0, 0, 0));
            count2++;
        }
    }
}


