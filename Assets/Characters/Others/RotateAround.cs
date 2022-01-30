using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateAround : MonoBehaviour
{
    private Rigidbody2D rb;

    public float radius;
    public float mag;
    public float dps;
    
    [SerializeField] 
    Transform point;
    public float degrees;


    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        float x = (point.position.x - rb.position.x);
        float y = (point.position.y - rb.position.y);
        radius = Mathf.Sqrt(x * x + y * y);
        degrees = Mathf.Atan2(y, x);
        dps = ((6.283f * radius) * mag);
  
    }

    void FixedUpdate()
    {
        //rb.velocity = new Vector2(mag * Mathf.Sin((degrees / 360) * (2f * Mathf.PI)), mag * Mathf.Cos((degrees / 360) * (2f * Mathf.PI)));
        degrees = (degrees + (dps * Time.fixedDeltaTime));
        rb.position = new Vector2(point.position.x + radius * Mathf.Sin(degrees), point.position.y + radius * Mathf.Cos(degrees));
    }
}
