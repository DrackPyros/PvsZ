using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    private GameController gameController;
    private Animator animator;
    private int speed;
    
    void Start()
    {
        gameController = GameObject.Find("EventS").GetComponent<GameController>();
        animator = GetComponent<Animator>();
    }

    void Update()
    {
        if (gameController.diff == 1)
            speed = 2;
        else 
            speed = gameController.diff;

        transform.Translate(Vector3.forward * Time.deltaTime * speed);
        
        animator.SetFloat("Speed_f", speed);
    }

    void OnTriggerEnter(Collider other){
        if (other.CompareTag("Player"))
        {
            Destroy(gameObject);
        }
        if (other.CompareTag("Goal"))
        {
            Destroy(gameObject);
            gameController.Loose();
        }
    }
}
