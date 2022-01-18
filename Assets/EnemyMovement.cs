using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    private GameController gameController;
    
    private int speed;
    
    void Start()
    {
        gameController = GameObject.Find("EventSystem").GetComponent<GameController>();
        if (gameController.diff == 1)
            speed = 2;
        else if (gameController.diff == 2)
            speed = 3;

    }

    void Update()
    {
        if (gameController.diff >= 3)
        {
            transform.Translate(Vector3.forward * Time.deltaTime * Random.Range(2f, 5f));
        }
        else
            transform.Translate(Vector3.forward * Time.deltaTime * speed);
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
