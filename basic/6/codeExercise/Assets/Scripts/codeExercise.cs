using UnityEngine;

public class codeExercise : MonoBehaviour
{
    // Variables

    public int number = 5;
    int factorial;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        calculateFactorial(number);

        Debug.Log($"The factorial of {number} is {factorial}");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // Calculate the factorial
    int calculateFactorial( int number)
    {
        factorial = 1;

        int counter = 1;

        while (counter <= number)
        {

            factorial = factorial * counter;

            counter++;

        }


        return factorial;
    }

}
