using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move1 : MonoBehaviour
{
    float dirx, moveSpeed = 1f;
    bool moveRight = true;

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x > -14.6f)
            moveRight = false;
        if (transform.position.x < -16.3f)
            moveRight = true;

        if (moveRight)
            transform.position = new Vector2(transform.position.x + moveSpeed * Time.deltaTime, transform.position.y);
        else
            transform.position = new Vector2(transform.position.x - moveSpeed * Time.deltaTime, transform.position.y);
    }
}