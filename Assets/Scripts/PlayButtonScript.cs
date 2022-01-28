using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayButtonScript : MonoBehaviour
{
    public GameObject loadingCamera;

    public void Pinxo()
    {
        loadingCamera.SetActive(false);
        //SceneManager.UnloadSceneAsync("Game Scene");
    }
}
