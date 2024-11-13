using UnityEngine;

public class DestroySphere : MonoBehaviour
{

    private void OnMouseDown()
    {
        Destroy(gameObject, 2f);
    }
}
