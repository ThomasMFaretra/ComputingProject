using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RiseAndLunge : MonoBehaviour
{
    private Rigidbody2D rb;
    private CooldownControl cc;
    private Position pos;
    private Switch ch;

    public bool start = false;

    public float movementLagTime;
    public float abilityLagTime;
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

    private bool canRise = false;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        cc = GetComponent<CooldownControl>();
        pos = GetComponent<Position>();
        ch = GetComponent<Switch>();
    }

    private void Update()
    {
        if (pos.isGrounded == true && canRise == false) //Resets canLock(allows another dash)
        {
            canRise = true;
        }

        if (Input.GetKeyDown("t") == true && start == false && cc.canUse == true && ch.character == 0f && canRise == true)
        {
            start = true;
            canRise = false;
            cc.countdownTime = upTime + fallTime + movementLagTime;
            cc.canUseTime = upTime + fallTime + abilityLagTime;
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
                if (fallTimeCounter > 0 && pos.isGrounded == false)
                {
                    fallTimeCounter -= Time.deltaTime;
                    cc.gravity = false;
                    rb.velocity = new Vector2((fallVector.x * direction) * fallMultiplierX, fallVector.y * fallMultiplierY);
                }
                else
                {
                    start = false;
                    cc.gravity = true;
                }
            }
        }        
    }
}
