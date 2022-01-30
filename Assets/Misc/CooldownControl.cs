using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CooldownControl : MonoBehaviour
{
    private PlayerControl pm;
    private Rigidbody2D rb;
    
    public float countdownTime; //Puts player movement on cooldown
    
    public bool canUse = true; //Puts abilites on cooldown
    public float canUseTime;

    public bool gravity = true;
    public float gravityScale;
    public float gravityTime;
   

    void Start()
    {
        pm = GetComponent<PlayerControl>();
        rb = GetComponent<Rigidbody2D>();
        gravityScale = rb.gravityScale;
    }

    void FixedUpdate()
    {
        CountdownCheck();
        CanUseCheck();
        GravityCheck();
        GravitySwitch();
    }
    
    void CountdownCheck()
    {
        // Movement Disabling
        if (countdownTime > 0) //for as long as cooldownTime isnt zero you wont be able to move
        {
            pm.enabled = false;
            countdownTime -= Time.fixedDeltaTime;
            if (countdownTime <= 0)
            {
                pm.enabled = true;
            }
        }
    }


    void CanUseCheck()
    {
        // Ability Disabling
        if (canUseTime > 0) //for as long as canUseTime isnt zero you wont be able to use abilities
        {
            canUse = false;
            canUseTime -= Time.fixedDeltaTime;
        }
        else
        {
            canUse = true;
        }
    }

    void GravityCheck()
    {
        if (gravityTime > 0) //for as long as gravityTime isnt zero gravity will be disabled
        {
            gravity = false;
            gravityTime -= Time.fixedDeltaTime;
        }
        else
        {
            gravity = true;
        }
    }
    
    void GravitySwitch()
    {
        if (gravity == false)
        {
            rb.gravityScale = 0;
        }
        else
        {
            rb.gravityScale = gravityScale;
        }
    }
}
