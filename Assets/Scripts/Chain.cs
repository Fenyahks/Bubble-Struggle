using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chain : MonoBehaviour
{
    public Transform player;
    public float speed = 1f;
    public static bool isFire;
    void Start()
    {
        isFire = false;
    }

    void Update()
    {
        //Debug.Log(isFire);
        if (isFire)
        {
            transform.localScale += Vector3.up * speed *Time.deltaTime;
        }
        else
        {
            transform.position = player.position;
            transform.localScale = new Vector3(1, 0, 0);
        }

        if (Input.GetButtonDown("Fire1"))
            {
                isFire = true;
            }
    }
}
