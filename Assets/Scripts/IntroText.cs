using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class IntroText : MonoBehaviour
{
    public Text introduccion;
    public GameObject im1;
    public GameObject im2;
    public string[] txt = new string[6];
    private int i = 0;
    void Start()
    {
        im1.SetActive(false);
        im2.SetActive(false);
        introduccion = gameObject.GetComponent<Text>();

        txt[0] = "Has aparecido en este mundo de una manera un tanto extraña.";
        txt[1] = "Estabas en tu casa, caiste en un sueño profundo, y al abrir los ojos esto es lo primero que ves.";
        txt[2] = "Oh noOooOOOOooO";
        txt[3] = "Unos zombies pretenden atacarte, defende la muralla para que no te maten.";
        txt[4] = "Para moverte utiliza las teclas A y D";
        txt[5] = "Los medidores de Fuerza y Angulo modifican la trayectoria de la pelota";
    }

    void Update()
    {
        if(i < txt.Length)
        {
            if(i == 4)
            {
                im1.SetActive(true);
            }
            else if(i == 5)
            {
                im1.SetActive(false);
                im2.SetActive(true);
            }
            introduccion.text = txt[i];

            if (Input.GetKeyDown(KeyCode.Return)){
                i+=1;
            }

        }
    }
}
