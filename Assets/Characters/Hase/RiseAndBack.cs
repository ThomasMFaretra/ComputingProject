using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RiseAndBack : MonoBehaviour
{
    private Rigidbody2D rb;
    private CooldownControl cc;
    private Position pos;
    private Switch ch;

    private bool start = false;

    public float lagTime;
    private float trueLagTime;

    private float direction;
    
    public float upTime;
    private float upTimeCounter;
    public float upForce;

    public float fallTime;
    private float fallTimeCounter;
    public Vector2 fallVector;
    public float fallMultiplierX;
    public float fallMultiplierY;
    public bool canRise = false;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        cc = GetComponent<CooldownControl>();
        pos = GetComponent<Position>();
        ch = GetComponent<Switch>();
    }

    void Update()
    {
        if (pos.isGrounded == true && canRise == false) //Resets canRise(allows another dash)
        {
            canRise = true;
        }

        if (Input.GetKeyDown("t") == true && start == false && cc.canUse == true && ch.character == 2f && canRise == true)
        {
            start = true;
            canRise = false;
            trueLagTime = upTime + fallTime + lagTime;
            cc.countdownTime += trueLagTime;
            cc.canUseTime += trueLagTime;
            upTimeCounter = upTime;
            fallTimeCounter = fallTime;
            direction = pos.lastDirection;
        }

        if (start == true)
        {
            if (upTimeCounter > 0)
            {
                upTimeCounter -= Time.deltaTime;
                rb.velocity = new Vector2(rb.velocity.x, upForce);
            }
            else
            {
                if (fallTimeCounter > 0)
                {
                    fallTimeCounter -= Time.deltaTime;
                    rb.velocity = new Vector2((fallVector.x * direction) * fallMultiplierX, fallVector.y * fallMultiplierY);
                }
                else
                {
                    start = false;
                }
            }
        }        
    }
}
