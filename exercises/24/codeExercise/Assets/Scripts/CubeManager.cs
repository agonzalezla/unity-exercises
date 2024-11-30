using UnityEngine;

public class CubeManager : MonoBehaviour
{
    public GameObject prefabCube;
    private int cubeHeight = 3;
    private int cubeWidth = 3;
    private int cubeDepth = 3;


    void Start()
    {
        
        for (int i = 0; i < cubeHeight; i++)
        {
            for(int j = 0; j < cubeWidth; j++)
            {
                for (int k = 0; k < cubeDepth; k++)
                {
                    Instantiate(prefabCube, new Vector3(i, j, k),Quaternion.identity);
                }
            }

        }



    }

}
