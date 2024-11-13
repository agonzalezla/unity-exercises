using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class codeExercice : MonoBehaviour
{

    // Variables

    private string firstSentence = "This is a sentence";
    private string secondSentence = "concatenation exercise";
    


    // Start is called before the first frame update
    void Start()
    {
        string concatenation = firstSentence + secondSentence;
        Debug.Log(concatenation);

        string concatenationWhithSpaces = firstSentence + " " + secondSentence;
        Debug.Log(concatenationWhithSpaces);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
