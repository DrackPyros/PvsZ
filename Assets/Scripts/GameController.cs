using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameController : MonoBehaviour
{
    public int diff;
    public Slider a; //Angle Y axis
    public Slider f; //Force Z axis
    int contador;
    public Camera MapCamera;
    public GameObject roundsimg;
    public GameObject looseimg;

    void Start()
    {
        a = GameObject.Find("AngleSlider").GetComponent<Slider>();
        f = GameObject.Find("ForceSlider").GetComponent<Slider>();

        MapCameraView();
        looseimg.SetActive(false);
    }
    void Update()
    {
        roundsimg.GetComponent<Text>().text = "Ronda: "+ diff;
    }
    public void Win()
    {
        Debug.Log("You Win");
    }
    public void Loose()
    {
        if(contador == 5)
        {
            looseimg.SetActive(true);
            Time.timeScale = 0;
        }
        contador++;
    }
    void MapCameraView()
    {
        int cameraHeight = 25;
        float desiredAspect = 4f/3f;
        float aspect = Camera.main.aspect;
        float ratio =  desiredAspect / aspect;
        MapCamera.orthographicSize = cameraHeight * ratio;
    }
}
