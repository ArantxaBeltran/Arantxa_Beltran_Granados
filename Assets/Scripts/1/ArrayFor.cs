using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrayFor : MonoBehaviour
{
    private float[] primercorte = { 25, 45, 50,34};
    public float[] segundocorte = new float[4];

    void Start()
    {

        //Debug.Log("Notas Primer Corte" + primercorte[0]+ primercorte[1]+primercorte[2]+primercorte[3]);
        //Debug.Log("Notas Segundo Corte" + segundocorte[0] + segundocorte[1] + segundocorte[2] + segundocorte[3]);
       
      float promediouno = (primercorte[0] + primercorte[1] + primercorte[2] + primercorte[3]) / 4;
      float promediodos = (segundocorte[0] + segundocorte[1] + segundocorte[2] + segundocorte[3]) / 4;
        float notafinal = (promediouno + promediodos) / 2;



        for (int i = 0; i < primercorte.Length;i++)
        {
            Debug.Log("Notas Primer Corte" + primercorte [i]);
        }
        for (int i = 0; i <segundocorte.Length; i++)
        {
            Debug.Log("Notas Segundo Corte" + segundocorte[i]);
        }

        Debug.Log("La nota final es" + notafinal );

  

    }

   
}
