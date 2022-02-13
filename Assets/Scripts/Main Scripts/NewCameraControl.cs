using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewCameraControl : MonoBehaviour
{
    public Transform target;
    public float smoothSpeed = 0.125f;
    public float magnitude;
    public Vector3 Offset;

    void Start()
    {
        transform.position = Offset;
    }
    
    void FixedUpdate()
    {
        transform.localPosition = Vector3.Lerp(Offset, new Vector3(target.GetComponent<Rigidbody2D>().velocity.x * magnitude, target.GetComponent<Rigidbody2D>().velocity.y * magnitude, -15f), smoothSpeed);
    }
}
