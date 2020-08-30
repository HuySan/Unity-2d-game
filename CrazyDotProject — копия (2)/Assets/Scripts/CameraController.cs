using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class CameraController : MonoBehaviour {
    public Transform target;//determine where the object is
    public float SmoothSpeed = 0.125f;
    public Vector3 offset;
    Vector3 position;


 void FixedUpdate()//happens after UPDATE, thereby the camera will move more smoothly
    {
        if (target != null)
        {
            Vector3 desiredPosition = target.position + offset;

            Vector3 SmoothedPosition = Vector3.Lerp(transform.position, desiredPosition, SmoothSpeed);

            transform.position = SmoothedPosition;
        }
    }


}
