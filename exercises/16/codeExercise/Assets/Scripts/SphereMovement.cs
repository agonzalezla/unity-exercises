using UnityEngine;

public class SphereMovement : MonoBehaviour
{

    void Update()
    {
        if (Input.GetKeyUp(KeyCode.Space))
        {
            transform.position += new Vector3(0, 0, 1);
        }

    }
}
