using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class Switch : MonoBehaviour
{
    private string comando;
    public float velocidad;
    public Text inputfield;

    public void Ejecutar()
    {

        comando = inputfield.text;
        switch (comando)
        {
            case "left":

                transform.position += Vector3.left * velocidad * Time.deltaTime;
                break;

            case "rigth":

                transform.position += Vector3.right * velocidad * Time.deltaTime;
                break;
            case "up":

                transform.position += Vector3.up * velocidad * Time.deltaTime;
                break;
            case "down":

                transform.position += Vector3.down * velocidad * Time.deltaTime;
                break;



        }
    }
    }
