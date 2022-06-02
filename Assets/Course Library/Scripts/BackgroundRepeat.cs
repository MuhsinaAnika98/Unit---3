using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundRepeat : MonoBehaviour
{
    float repeatWidth;
    Vector3 startPos;
    void Start()
    {
        startPos = transform.position;
        repeatWidth = GetComponent<BoxCollider>().size.x/2;
    }
    // Update is called once per frame
    void Update()
    {
        if(transform.position.x<(startPos.x-repeatWidth))
        {
            transform.position = startPos;

        }
    }
}
