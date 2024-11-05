using UnityEngine;

public class PlayerController : MonoBehaviour
{


    public float playerSpeed = 2.0f;

    private float movementY = 0f;

    void Update()
    {
        float movementX = Input.GetAxis("Horizontal");

        float movementZ = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(movementX, movementY, movementZ);

        movement.Normalize();

        transform.Translate(movement * playerSpeed * Time.deltaTime);

    }
}
