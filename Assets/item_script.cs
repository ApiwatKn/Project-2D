using UnityEngine;
using System.Collections.Generic;
using System.Collections;
using UnityEngine.UI;
public class item_script : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Collider2D c;
        if(!GetComponent<Collider2D>())
        {
            c = gameObject.AddComponent<BoxCollider2D>();
        }
        else
        {
            c = GetComponent<Collider2D>();
        }
        c.isTrigger = true;
    }

    // Note: The correct method name is OnTriggerEnter2D, not OntriggerEnter2D
    void OnTriggerEnter2D(Collider2D other)
    {
       AudioSource audio = GetComponent<AudioSource>();
       audio.Play();

        Destroy(gameObject,0.5f);
    }

    // Update is called once per frame
    void Update()
    {

    }
}