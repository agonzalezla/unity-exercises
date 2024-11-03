using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class MovementCube : MonoBehaviour
{

    private float firstPoint = 0f;
    private float secondPoint = 10f;

    public float speed = 3.0f;

    private int spin = 1;



    void Update()
    {
        transform.Translate(Vector3.right * speed * spin * Time.deltaTime);

        if (transform.position.x >= secondPoint || transform.position.x <= firstPoint) {

            spin *= -1;

        }
    }
}
