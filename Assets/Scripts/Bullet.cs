using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{    
    
    void Start()
    {
        
    }

    void Update()
    {
           
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        Chain.isFire = false;
        if (other.tag == "Circle")
        {
            other.GetComponent<CircleSript>().SplitCircle();
            Debug.Log("123");
        }
    }
}
