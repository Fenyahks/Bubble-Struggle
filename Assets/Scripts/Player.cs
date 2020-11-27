using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    public float speed = 5f;
    public Rigidbody2D rb;
    private float movement = 0;
    void Start()
    {
        
    }

    void Update()
    {
        movement = Input.GetAxisRaw("Horizontal") * speed;
    }

    private void FixedUpdate()
    {
        rb.MovePosition(rb.position + new Vector2(movement * Time.fixedDeltaTime, 0));
    }

    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.collider.tag == "Circle")
        {
            SceneManager.LoadScene("SampleScene");
        }
    }
}
