using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControll : MonoBehaviour
{
    private int pos = 0;
    private float [] spawnpoints; 
    private Rigidbody rig;
    private float a; //Angle Y axis
    private float f; //Force Z axis
    
    void Start(){
        rig = GetComponent<Rigidbody>();
        spawnpoints = GameObject.Find("EventSystem").GetComponent<PlayerGenerator>().spawnpoints;
    }
    void Update()
    {
        a = GameObject.Find("EventSystem").GetComponent<GameController>().a.value;
        f = GameObject.Find("EventSystem").GetComponent<GameController>().f.value;

        if (Input.GetKeyDown(KeyCode.Space)){
            print(f + " -- " + a);
            //transform.Translate(Vector3.forward * Time.deltaTime * speed);
            rig.AddForce(0, a, f, ForceMode.Impulse);
        }
        if (Input.GetKeyDown(KeyCode.A)){pos--;}
        else if (Input.GetKeyDown(KeyCode.D)){pos++;}
        
        if (pos < 0){pos = spawnpoints.Length-1;}
        else if (pos >= spawnpoints.Length){pos = 0;}

        transform.position = new Vector3(spawnpoints[pos], 1, -20);
        //Separar en Jugador y proyectil
    }
    void OnTriggerEnter(Collider other){
        if (other.CompareTag("Board"))
        {
            Destroy(gameObject);
            PlayerGenerator.alive = false;
        }
    }
}
