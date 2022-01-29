using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScreemSound : MonoBehaviour
{
    private AudioSource scream;

    void Start(){
        scream = GetComponent<AudioSource>();
    }
    public void Play()
    {
        scream.Play();
    }
}
