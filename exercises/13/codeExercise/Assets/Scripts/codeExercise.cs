using UnityEngine;

public class codeExercise : MonoBehaviour
{


    public float speedResize = 1.0f;

    public float minSize = 1.0f;


    void Update()
    {

        if (Input.GetKey(KeyCode.Space))
        {

            transform.localScale += Vector3.one * speedResize * Time.deltaTime;
        }
        else {

            transform.localScale = Vector3.Max(transform.localScale - Vector3.one * speedResize * Time.deltaTime, Vector3.one * minSize);        
        
        }


    }
}
