using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Diccionario : MonoBehaviour
{
    public Dictionary<string, float> enemigos = new Dictionary<string, float>();
    public int aumentovida;
    
   

    private void Start()
    {
        enemigos.Add("Camil", 10);
        enemigos.Add("Caina", 13);
        enemigos.Add("Cal", 15);

        

       foreach (KeyValuePair<string,float> ene in enemigos)
        {
            Debug.Log("enemigo" + ene.Key + ",vida:"+ ene.Value );
        }
        foreach (KeyValuePair<string, float> ene in enemigos)
        {
            Debug.Log("enemigo" + ene.Key + ",vida:" + (ene.Value+aumentovida));
        }



    }

}




