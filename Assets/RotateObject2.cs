using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateObject2 : MonoBehaviour
{
    public float rotationSpeed = 1f;
    private bool leftIsPressed = false;
    private bool rightIsPressed = false;
    
    public void RightRotateDown()
    {
        rightIsPressed = true;
    }

    public void RightRotateUp()
    {
        rightIsPressed = false;
    }
    
    public void LeftRotateDown()
    {
        leftIsPressed = true;
    }

    public void LeftRotateUp()
    {
        leftIsPressed = false;
    }

    private void Update()
    {
        if (leftIsPressed)
        {
            transform.Rotate(0, -rotationSpeed,0);
        }

        if (rightIsPressed)
        {
            transform.Rotate(0,rotationSpeed,0);
        }
    }
}
