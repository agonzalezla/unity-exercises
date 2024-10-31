using UnityEngine;

public class codeExercise : MonoBehaviour
{

    int frameCounter = 0;

    // Update is called once per frame
    void Update()
    {
        frameCounter++;
        
        if (frameCounter % 100 == 0)
        {
            float executionTime = Time.time;
            Debug.Log("The elapsed time in these 100 frames is: " + executionTime);
        }
    }
}
