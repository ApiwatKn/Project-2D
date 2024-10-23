using UnityEngine;
using System.Collections.Generic;
using System.Collections;

public class Move5 : MonoBehaviour
{
    float dirx,moveSpeed = 4f;
    bool moveRight = true;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.x>13f)
        moveRight = false;
        if(transform.position.x<10f)
        moveRight = true;
        if(moveRight)
        transform.position = new Vector2(transform.position.x+moveSpeed*Time.deltaTime,transform.position.y);
        else
        transform.position = new Vector2(transform.position.x-moveSpeed*Time.deltaTime,transform.position.y);
    }
}
