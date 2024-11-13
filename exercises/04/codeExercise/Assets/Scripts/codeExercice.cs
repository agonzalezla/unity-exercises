using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class codeExercice : MonoBehaviour
{

    private bool isTrue;

    public int firstNumber = 5;
    public int secondNumber = 15;


    // Start is called before the first frame update
    void Start()
    {
    
        int sumNumbers = firstNumber + secondNumber;
        isTrue = (sumNumbers % 2 == 0);

        Debug.Log("The sum of the numbers " + firstNumber + " + " + secondNumber + " is even? " + isTrue);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
