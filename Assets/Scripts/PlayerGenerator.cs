using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerGenerator : MonoBehaviour
{
    private SpawnEnemy spawnP;
    private GameController gameController;
    public float [] spawnpoints; 
    
    void Start()
    {
        gameController = GameObject.Find("EventSystem").GetComponent<GameController>();
    }

    public float[] GenerateSpawnPoints(){
        spawnP = GameObject.Find("SpawnerP").GetComponent<SpawnEnemy>();
        float [] coords = new float [8];
        int aux = 0;
        float temp;
        foreach(Transform child in spawnP.transform){
            coords[aux] = child.position.x;
            aux++;
        }
        for (int j = 0; j <= coords.Length - 2; j++) {
            for (int i = 0; i <= coords.Length - 2; i++) {
                if (coords[i] > coords[i + 1]) {
                    temp= coords[i + 1];
                    coords[i + 1] = coords[i];
                    coords[i] = temp;
               }
            }
        }
        return coords;
    }
}
