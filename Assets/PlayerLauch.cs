using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerLauch : MonoBehaviour
{
    private SpawnEnemy spawnP;
    private GameController gameController;
    private Vector3 [] spawnpoints; 
    private Rigidbody rigidBody;
    
    private int i = 0;
    void Start()
    {
        spawnP = GameObject.Find("SpawnerP").GetComponent<SpawnEnemy>();
        gameController = GameObject.Find("EventSystem").GetComponent<GameController>();
        rigidBody = GetComponent<Rigidbody>();
        spawnpoints = GenerateSpawnPoints(spawnP);
    }

    void FixedUpdate()
    {
        //float horizontal = Input.GetAxis("Horizontal");
        if (Input.GetKeyDown(KeyCode.A)){i--;}
        else if (Input.GetKeyDown(KeyCode.D)){i++;}
        
        //if (horizontal > 0){i++;} else if (horizontal < 0) i--;

        if (i < 0){i = spawnpoints.Length-1;}
        else if (i >= spawnpoints.Length){i = 0;}

        transform.position = new Vector3(spawnpoints[i].x, 1, -20);
    }
    Vector3[] GenerateSpawnPoints(SpawnEnemy spawnP){
        Vector3 [] coords = new Vector3 [8];
        int aux = 0;
        foreach(Transform child in spawnP.transform){
            coords[aux] = child.position;
            aux++;
        }
        return coords;
    }
}
