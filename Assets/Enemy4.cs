using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy4 : MonoBehaviour
{
    float dirx, moveSpeed = 2f;
    bool moveRight = true;

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x > 72f)
            moveRight = false;
        if (transform.position.x < 69.5f)
            moveRight = true;

        if (moveRight)
            transform.position = new Vector2(transform.position.x + moveSpeed * Time.deltaTime, transform.position.y);
        else
            transform.position = new Vector2(transform.position.x - moveSpeed * Time.deltaTime, transform.position.y);
    }
}
