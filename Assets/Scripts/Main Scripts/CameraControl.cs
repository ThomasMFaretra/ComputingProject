using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControl : MonoBehaviour
{
    public Transform target;
    public float smoothSpeed = 0.125f;
    public Vector3 Offset;

    void FixedUpdate()
    {
        transform.position = Vector3.Lerp(transform.position, target.position + Offset, smoothSpeed);
    }
}
