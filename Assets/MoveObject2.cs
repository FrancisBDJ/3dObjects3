using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveObject2 : MonoBehaviour
{
    public float speed = 6f;
    private bool backIsPressed = false;
    private bool forwardIsPressed = false;
    private bool leftIsPressed = false;
    private bool rightIsPressed = false;
    
    public void MoveForwardDown()
    {
        forwardIsPressed = true;
    }

    public void MoveForwardUp()
    {
        forwardIsPressed = false;
    }
    
    public void MoveBackDown()
    {
        backIsPressed = true;
    }

    public void MoveBackUp()
    {
        backIsPressed = false;
    }
    
    public void MoveRightDown()
    {
        rightIsPressed = true;
    }

    public void MoveRightUp()
    {
        rightIsPressed = false;
    }
    
    public void MoveLeftDown()
    {
        leftIsPressed = true;
    }

    public void MoveLeftUp()
    {
        leftIsPressed = false;
    }

    private void Update()
    {
        if (forwardIsPressed)
        {
            transform.position += Vector3.forward * speed * Time.deltaTime;
        }

        if (backIsPressed)
        {
            transform.position += Vector3.back * speed * Time.deltaTime;
        }

        if (leftIsPressed)
        {
            transform.position += Vector3.left * speed * Time.deltaTime;
        }

        if (rightIsPressed)
        {
            transform.position += Vector3.right * speed * Time.deltaTime;
        }
    }
}
