using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class List : MonoBehaviour
{
    public List<string> poderes;
    public List<float> valorpoder;
    private void Start()
    {
       poderes.Insert(0, "Burbujas");
       poderes.Insert(1, "Girasoles");
       poderes.Insert(2, "Espinas");

       valorpoder.Insert(0,10f);
       valorpoder.Insert(1,20f);
       valorpoder.Insert(2,30f);

       string poderuno= (poderes[0] + valorpoder[0]);
       string poderdos = (poderes[1] + valorpoder[1]);
       string podertres = (poderes[2] + valorpoder[2]);

        Debug.Log(poderuno + poderdos + podertres);








    }
}
