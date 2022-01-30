using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackdropScript : MonoBehaviour
{
    public Camera cam;
    public Vector3 offset;
    void Start()
    {
        transform.position = offset;
    }


    void Update()
    {
        transform.position = new Vector3(cam.transform.position.x + offset.x, offset.y, offset.z);
    }
}
