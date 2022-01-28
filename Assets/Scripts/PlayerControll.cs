using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControll : MonoBehaviour
{
    private int pos = 0;
    private float [] spawnpoints; 
    private float a; //Angle Y axis
    private float f; //Force Z axis
    public GameObject playerPrefab;
    private GameObject player;
    public static bool alive = false;
    private GameController gameController;
    
    void Start(){
        gameController = GameObject.Find("EventS").GetComponent<GameController>();
        spawnpoints = GameObject.Find("EventS").GetComponent<PlayerGenerator>().GenerateSpawnPoints();
    }
    void Update()
    {
        a = gameController.a.value;
        f = gameController.f.value;

        if (Input.GetKeyDown(KeyCode.Space))
        {
            player.GetComponent<ProyectileBehaviour>().Implulse(a, f);
            alive = false;
        }
        if (Input.GetKeyDown(KeyCode.A)){pos--;}
        else if (Input.GetKeyDown(KeyCode.D)){pos++;}
        
        if (pos < 0){pos = spawnpoints.Length-1;}
        else if (pos >= spawnpoints.Length){pos = 0;}

        transform.position = new Vector3(spawnpoints[pos], 1, -20);
        if(alive){
            player.transform.position = new Vector3(spawnpoints[pos], 1, -20);
        }
    }

    void FixedUpdate(){
        if (!alive)
        {
            player = Instantiate(playerPrefab, new Vector3(spawnpoints[pos], 1, -20), Quaternion.identity);
            alive = true;
        }
    }
    
}
