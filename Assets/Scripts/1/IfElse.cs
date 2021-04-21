using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IfElse : MonoBehaviour
{    
    public int num;
    
    private void Start()
    {
        if (num % 2 == 0)
        {
            Debug.Log("Es un numero par");
        }
        else 
        {
            Debug.Log("Es un numero impar");
        }
    }

}
