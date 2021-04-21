using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ElseIf : MonoBehaviour
{
   public Material cube;

    private void Start()
    {
       cube = GetComponent<Renderer>().material;
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.B))
        {
            cube.color = Color.red;
        }
        

    }
}
