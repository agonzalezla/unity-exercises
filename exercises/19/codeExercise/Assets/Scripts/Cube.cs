using UnityEngine;

public class Cube : MonoBehaviour
{

    private bool cubeEnable = true;

    private void OnMouseDown()
    {
        if (cubeEnable)
        {
            cubeEnable = false;
            TimeDisable(Random.Range(2, 4));

        }
    }

    private void TimeDisable(int time)
    {
        Invoke("DisableCube", time);
    }

    private void DisableCube()
    {
        gameObject.SetActive(false);
    }

}


