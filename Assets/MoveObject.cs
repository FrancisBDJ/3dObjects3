using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;




public class MoveObject : MonoBehaviour
{
    public float speed = 10f;
   
    void Update()
    {
        if (Touchscreen.current.primaryTouch.press.isPressed)
        {
            Vector3 touchPosition = Touchscreen.current.primaryTouch.position.ReadValue();
            Debug.Log("touch screen space: " + touchPosition);
            Ray ray = Camera.main.ScreenPointToRay(touchPosition);
            Debug.DrawRay(ray.origin, ray.direction*100f, Color.red);
            Vector3 deltaTouch = Touchscreen.current.primaryTouch.delta.ReadValue();


            if (Physics.Raycast(ray, out RaycastHit hitInfo, 100f, LayerMask.GetMask("RaycastTarget")))
            {
                
                touchPosition.z = hitInfo.transform.position.z;
                Vector3 worldPosition = Camera.main.ScreenToWorldPoint(touchPosition);
                Vector3 newPosition = new Vector3(worldPosition.x * speed, hitInfo.transform.position.y, touchPosition.z) ;
                hitInfo.transform.position = newPosition;
            }
        }
    }
}
