using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameController : MonoBehaviour
{
    public int diff;
    public Slider a; //Angle Y axis
    public Slider f; //Force Z axis

    void Start()
    {
        a = GameObject.Find("AngleSlider").GetComponent<Slider>();
        f = GameObject.Find("ForceSlider").GetComponent<Slider>();
    }

    void Update()
    {
        //print(a.value);
    }
    public void Win()
    {
        Debug.Log("Funciona");
    }
    public void Loose()
    {
        Debug.Log("You Loose");
    }
    
}
