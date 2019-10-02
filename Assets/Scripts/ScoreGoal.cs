using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreGoal : MonoBehaviour {
    private int count1;
   
      // Use this for initialization
   void Start () {
        count1 = 0;
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
            col.gameObject.transform.Translate(new Vector3(0, 0, 2.25f));
            count1++;
        }
    }
}


