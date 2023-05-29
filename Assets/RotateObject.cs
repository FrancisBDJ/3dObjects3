using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RotateObject : MonoBehaviour
{
    public float rotationSpeed = 6;

   

    public void RotateToLeft()
    {
        Debug.Log("giro a la derecha");
        
        //transform.rotation.y += 30f;
        transform.Rotate(0,-30f,0);
    }
    
    public void RotateToRight()
    {
        Debug.Log("giro a la izquierda");
        transform.Rotate(0,30f,0);
    }
    
}
