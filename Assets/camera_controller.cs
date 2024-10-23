using UnityEngine;
using System.Collections;
using System.Collections.Generic;
public class camera_controller : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public Transform obj;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(obj.position.x,transform.position.y,transform.position.z);
    }
}
