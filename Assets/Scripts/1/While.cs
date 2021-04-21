using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class While : MonoBehaviour
{
    
  void Start()
        
    {
        int contadorregresivo = 20 ;

        while (contadorregresivo <= 20)
        {
            Debug.Log("Quedan" + contadorregresivo + "seg para iniciar" );
            contadorregresivo -= 2;
        }




    }
}
