using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class codeExercice : MonoBehaviour
{

    // Variables
    public float firstNumber = 13.0f;
    public float secondNumber = 4.0f;



    // Start is called before the first frame update
    void Start()
    {
      
        float sum = firstNumber + secondNumber;
        Debug.Log("The result of the sum n1 + n2 is " + sum );

        float subtract = firstNumber - secondNumber;
        Debug.Log("The result of the subtract n1 - n2 is " + subtract);

        float multiplication = firstNumber * secondNumber;
        Debug.Log("The result of the multiplication n1 * n2 is " + multiplication);

        float division = firstNumber / secondNumber;
        Debug.Log("The result of the division n1 / n2 is " + division);




    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
