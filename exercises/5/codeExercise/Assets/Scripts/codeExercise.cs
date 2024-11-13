using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class codeExercise : MonoBehaviour
{

    private DateTime date = DateTime.Now;
   

    // Start is called before the first frame update
    void Start()
    {

        DayOfWeek day = date.DayOfWeek;


        if (day == DayOfWeek.Monday)
        {
            Debug.Log("That's right, today is Monday");
        }
        else
        {
            Debug.Log("No today is not Monday, today is " + day);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
