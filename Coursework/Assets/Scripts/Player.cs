using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    float speed = 2.0f;
    Vector3 moveDirection;


    public void moveX()
    {
        moveDirection = new Vector3(0.5f, 0f, 0f);
        if (Input.GetKey(KeyCode.A))
        {
            GetComponent<Rigidbody>().velocity += moveDirection * speed;
        }
        if (Input.GetKey(KeyCode.D))
        {
            GetComponent<Rigidbody>().velocity -= moveDirection * speed;
        }
    }

    public void moveY()
    {
        moveDirection = new Vector3(0f, 0.5f, 0f);
        if (Input.GetKey(KeyCode.Space))
        {
            GetComponent<Rigidbody>().velocity += moveDirection * speed;
        }
        else
        {
            GetComponent<Rigidbody>().velocity -= moveDirection * speed;
        }

    }

    public void moveZ()
    {
        Vector3 moveDirection = new Vector3(0f, 0f, 0.5f);
        if (Input.GetKey(KeyCode.W))
        {
            GetComponent<Rigidbody>().velocity += moveDirection * speed;
        }
        if (Input.GetKey(KeyCode.S))
        {
            GetComponent<Rigidbody>().velocity -= moveDirection * speed;
        }
    }

    public void Update()
    {
        if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.D))
        {
            moveX();
        }
        if (Input.GetKey(KeyCode.Space))
        {
            moveY();
        }
        if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.S))
        {
            moveZ();
        }
    }
}
