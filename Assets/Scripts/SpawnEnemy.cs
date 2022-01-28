using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnEnemy : MonoBehaviour
{
    public static GameObject[] myObjects;
    private GameController gameController;
    public static float delayTime = 2;
    public static int sum = 0;
    private static float spawns = 10f;
    void Start()
    {
        myObjects = Resources.LoadAll<GameObject>("Prefabs/Characters/Humans");
        gameController = GameObject.Find("EventS").GetComponent<GameController>();
        
        InvokeRepeating("ChooseSpawn", 2.0f, delayTime);
    }
 
    void ChooseSpawn()
    {   
        float children = transform.childCount;
        Spawn(transform.GetChild((int)Random.Range(0f, children)));
        sum ++;
    }
    
    void Spawn(Transform child){
        Vector3 child_position = child.transform.position;

        float aux = myObjects.Length;
        int whichItem = (int)Random.Range(0f, aux);

        GameObject myObj = Instantiate (myObjects [whichItem]) as GameObject;

        myObj.transform.position = child_position;
        myObj.transform.Rotate(0, -180, 0);
    }
    void Update()
    {
        if (sum >= (int)spawns)
        {
            gameController.diff ++;
            spawns += 5;
            sum = 0;
            //CancelInvoke("ChooseSpawn");
        }
    }
}
