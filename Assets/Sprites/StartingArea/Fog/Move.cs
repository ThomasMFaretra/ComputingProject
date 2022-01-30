using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    public float direction;
    void FixedUpdate()
    {
        transform.position += Vector3.right * direction;
    }
}
