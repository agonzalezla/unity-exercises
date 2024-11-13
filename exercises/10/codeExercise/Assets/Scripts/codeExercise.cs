using UnityEngine;

public class codeExercise : MonoBehaviour
{

    private int randomNumberProbability;

    void Start()
    {
        randomNumberProbability = Random.Range(0, 101);

        InvokeRepeating("ComparationNumberProbability", 0f, 10f);
    }


    void ComparationNumberProbability()
    {
        int randomNumber = Random.Range(0, 101);

        if (randomNumber >= randomNumberProbability)
        {

            Debug.Log("Success");

        }
        else
        {
            Debug.Log("Fail");
        }

    }
}
