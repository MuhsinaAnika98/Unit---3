using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveLeft : MonoBehaviour
{
    float speed = 10f;
    PlayerController playerController;
    float leftBound = -10f;
    void Start()
    {
        // playerController = GameObject.Find("Player").GetComponent<PlayerController>();
        playerController = FindObjectOfType<PlayerController>();//easier
    }


    void Update()
    {
        if (playerController.gameOver == false)
        {
            transform.Translate(Vector3.left * speed * Time.deltaTime);


            if(transform.position.x<leftBound  && gameObject.CompareTag("Obstacle"))
            {

                Destroy(gameObject);
            }
        }
    }
}
