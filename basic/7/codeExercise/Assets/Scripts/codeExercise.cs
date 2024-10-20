using UnityEngine;

public class codeExercise : MonoBehaviour
{

    private void Awake()
    {
        Debug.Log("This method is called when the script is instantiated and before the 'Start' method is called.");
    }



    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Debug.Log("This method is called at the beginning of the game, after 'Awake' has been called.");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
