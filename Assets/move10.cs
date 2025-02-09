using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move10 : MonoBehaviour
{
    float dirx, moveSpeed = 1f;
    bool moveRight = true;

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x > 48f)
            moveRight = false;
        if (transform.position.x < 45.5f)
            moveRight = true;

        if (moveRight)
            transform.position = new Vector2(transform.position.x + moveSpeed * Time.deltaTime, transform.position.y);
        else
            transform.position = new Vector2(transform.position.x - moveSpeed * Time.deltaTime, transform.position.y);
    }
}