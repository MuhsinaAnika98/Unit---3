using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawnner : MonoBehaviour
{
    public GameObject obj;
    Vector3 spawnPos = new Vector3(11, 0, 0);
    float startDelay=3f, repeatRate=2f;
    PlayerController playerControllar;
    void Start()
    {
        InvokeRepeating("Spawn", startDelay, repeatRate);
        playerControllar = FindObjectOfType<PlayerController>();
    }


 
   void Spawn()
    {
        if(playerControllar.gameOver==false)
        { Instantiate(obj, spawnPos, obj.transform.rotation); }
       // Instantiate(obj, spawnPos, obj.transform.rotation);
    }
}
