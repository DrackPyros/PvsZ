using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProyectileBehabiour : MonoBehaviour
{
    private Rigidbody rig;
    void Start()
    {
        
        rig = gameObject.GetComponent<Rigidbody>();
    }
    public void Implulse (float a, float f)
    {
        rig.constraints = RigidbodyConstraints.None;
        rig.AddForce(0, a+f, f, ForceMode.Impulse);
    }
    void OnTriggerEnter(Collider other){
        if (other.CompareTag("Board"))
        {
            Destroy(gameObject);
            PlayerControll.alive = false;
        }
    }
}
