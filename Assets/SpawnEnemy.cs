using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnEnemy : MonoBehaviour
{
    public static GameObject[] myObjects;
    public static float delayTime = 2;
    public static int counter = 0;
    void Start()
    {
        myObjects = Resources.LoadAll<GameObject>("Prefabs/Characters/Humans");
        InvokeRepeating("ChooseSpawn", 2.0f, delayTime);
    }
 
    void ChooseSpawn()
    {
        float children = transform.childCount;
        Spawn(transform.GetChild((int)Random.Range(0f, children)));
        counter ++;
    }
    
    void Spawn(Transform child){
        Vector3 child_position = child.transform.position;
        print(child_position);

        float aux = myObjects.Length;
        int whichItem = (int)Random.Range(0f, aux);

        GameObject myObj = Instantiate (myObjects [whichItem]) as GameObject;

        myObj.transform.position = child_position;
    }
    void Update()
    {
        if (counter >= 10)
            CancelInvoke("ChooseSpawn");
    }
}
