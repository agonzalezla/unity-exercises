using System;
using UnityEngine;

public class exercise : MonoBehaviour
{

    public void Start()
    {

        int suma = 0;
        for (int i = 1; i <= 500; i++)
        {
            suma += 2 * i;
        }

        Console.WriteLine();


        Debug.Log("La suma de los primeros 500 números pares es: " + suma);

    }








}
