using UnityEngine;

public class MoveCube : MonoBehaviour
{

    [SerializeField] float speed = 1.0f;

    void Update()
    {

        transform.Translate(Vector3.right * speed * Time.deltaTime);

        if (transform.position.x >= 10) 
        {
            transform.position = new Vector3(0, transform.position.y, transform.position.z);
        }



    }
}
