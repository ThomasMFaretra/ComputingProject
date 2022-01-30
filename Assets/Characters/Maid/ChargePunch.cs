using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChargePunch : MonoBehaviour
{
    private Rigidbody2D rb;
    private CooldownControl cc;
    private Position pos;
    private SpriteRenderer spr;
    private Switch ch;

    public float movementEndLag;
    public float abilityEndLag;
    
    public float minimumDistance;

    public float dashVelocity;
    private float dashCharge;
    public float dashChargeIncreaser;

    public float shuffleSpeed;
    
    public float chargeLimit;
    private float currentChargeLimit;

    public float currentDirection;
    public float direction;

    private bool wasGrounded;

    private bool canCharge = false;
    private bool start = false;

    private ControlScheme controls;

    void Awake()
    {
        controls = new ControlScheme();
        controls.Main.Enable();
    }

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        cc = GetComponent<CooldownControl>();
        pos = GetComponent<Position>();
        spr = GetComponent<SpriteRenderer>();
        ch = GetComponent<Switch>();
    }

    void Update()
    {
        GroundCheck();
        if (start == false)
        {
            Starter();
        }
        else
        {
            Punch();
        }   
    }
    
    void Starter()
    {
        if (controls.Main.SideSpecial.ReadValue<float>() == 1 && start == false && cc.canUse == true && canCharge == true && ch.character == 0f)
        {
            start = true;
            canCharge = false;
            cc.countdownTime = movementEndLag;
            cc.canUseTime = abilityEndLag;
            currentChargeLimit = chargeLimit;
            direction = pos.lastDirection;
            wasGrounded = false;
        }
    }
    
    void GroundCheck()
    {
        if (pos.isGrounded == true) //Resets canLock(allows another dash)
        {
            canCharge = true;
        }
    }

    void Punch()
    {
        if (controls.Main.NeutralSpecial.ReadValue<float>() == 1 && currentChargeLimit > 0)
        {
            currentChargeLimit -= Time.deltaTime;
            cc.countdownTime += Time.deltaTime;
            cc.canUseTime += Time.deltaTime;
            currentDirection = controls.Main.Move.ReadValue<float>();
            if (currentDirection != direction && currentDirection != 0)
            {
                direction = currentDirection;
                SpriteFlip();
            }
            if (wasGrounded == false && pos.isGrounded == true)
            {
                wasGrounded = true;
            }
            if (wasGrounded == true)
            {
                rb.velocity = new Vector2(currentDirection * shuffleSpeed, rb.velocity.y);
            }
            else
            {
                rb.velocity = new Vector2(currentDirection * 10, rb.velocity.y);
            }
            dashCharge += Time.deltaTime * dashChargeIncreaser;
        }
        else
        {
            if (dashCharge > 0)
            {
                cc.gravityTime += Time.deltaTime;
                cc.countdownTime += Time.deltaTime;
                cc.canUseTime += Time.deltaTime;
                dashCharge -= Time.deltaTime;
                rb.velocity = new Vector2(dashVelocity * direction, 0f);
            }
            else
            {
                start = false;
            }
        }
    }

    void SpriteFlip()
    {
        if (direction == 1)
        {
            spr.flipX = false;
        }
        else
        {
            spr.flipX = true;
        }

    }

    void InputBinary()
    {
        if (currentDirection > 0)
        {
            currentDirection = 1;
        }
        if (currentDirection < 0)
        {
            currentDirection = -1;
        }
        else
        {
            currentDirection = 0;
        }

    }

    
}
