using UnityEngine;

public class codeExercise : MonoBehaviour
{

    float speedRotation = 30.0f;


    void Update()
    {
        float inputHorizonal = Input.GetAxis("Horizontal");

        float cubeRotation = inputHorizonal * speedRotation * Time.deltaTime;

        transform.Rotate(Vector3.up, cubeRotation);
    }
}
