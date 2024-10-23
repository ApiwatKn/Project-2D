using UnityEngine;
using System.Collections.Generic;
using System.Collections;

public class ZombieStomp : MonoBehaviour
{

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag=="Weak Point")
        {
            Destroy (collision.gameObject);
        }
    }
}
