using UnityEngine;

public class cubeRenamer : MonoBehaviour
{

    public GameObject cubeRename;
    private int counterClics = 0;

    private void OnMouseDown()
    {
        counterClics++;
        changeNameCube();
    }

    private void changeNameCube()
    {

        if (cubeRename != null)
        {
            cubeRename.name = counterClics.ToString();


        }

    }
}
