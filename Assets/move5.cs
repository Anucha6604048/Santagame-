using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move5 : MonoBehaviour
{
    float dirx, moveSpeed = 1f;
    bool moveUp = true;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.y > 2.75f)
            moveUp = false;
        if (transform.position.y < -1f)
            moveUp = true;

        if (moveUp)
            transform.position = new Vector2(transform.position.x, transform.position.y + moveSpeed * Time.deltaTime);
        else
            transform.position = new Vector2(transform.position.x, transform.position.y - moveSpeed * Time.deltaTime);
    }
}
