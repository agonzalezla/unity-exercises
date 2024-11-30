using UnityEngine;

public class WallManager : MonoBehaviour
{

    public GameObject prefabCube;
    private int wallHeight = 10;
    private int wallWidth = 10;

    
    void Start()
    {
        
        for (int i = 0; i < wallHeight; i++)
        {
            for (int j = 0; j < wallWidth; j++)
            {
                Instantiate(prefabCube, new Vector3(j, i, 0), Quaternion.identity);

            }


        }




    }

}
