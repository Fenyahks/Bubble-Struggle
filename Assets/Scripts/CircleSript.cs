using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;

public class CircleSript : MonoBehaviour
{
    public Vector2 startForce;
    public Rigidbody2D rb;
    public GameObject circle;
    void Start()
    {
        //Time.timeScale = 1;
        rb.AddForce(startForce, ForceMode2D.Impulse);
    }

    void Update()
    {
        
    }
    public void SplitCircle()
    {
        if (circle != null)
        {
            GameObject ball1 = Instantiate(circle, transform.position, quaternion.identity);
            GameObject ball2 = Instantiate(circle, rb.position + Vector2.left, quaternion.identity);
            ball1.GetComponent<CircleSript>().startForce = new Vector2(-3.5f, 5);
            ball2.GetComponent<CircleSript>().startForce = new Vector2(3.5f, 5);
        }

        Destroy(gameObject);
    }
}
