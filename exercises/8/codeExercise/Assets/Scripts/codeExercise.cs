using UnityEngine;

public class codeExercise : MonoBehaviour
{

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float timeElapse = Time.deltaTime;

        Debug.Log("The elapsed time since the last frame is: " + timeElapse);

    }
}
