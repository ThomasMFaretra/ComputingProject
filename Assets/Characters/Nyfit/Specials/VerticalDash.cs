using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VerticalDash : MonoBehaviour
{
    private Rigidbody2D rb;
    private CooldownControl cc;
    private Position pos;
    private Switch ch;
    public Animator animator;

    public float dashForce = 1f;
    public float lagTime;
    public float dashLength;
    private float dashTime;
   
    public bool isDashing = false;
    public bool canDash = false;

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
        ch = GetComponent<Switch>();
    }

    void Update()
    {
        CanDashReset();
        DashStart();
        if (start == true)
        {
            Dash();
        }
    }

    void CanDashReset()
    {
        if (pos.isGrounded == true && isDashing == false) //Resets canDash (allows another dash)
        {
            canDash = true;
        }
    }

    void Dash()
    {
        if (dashTime > 0)
        {
            dashTime -= Time.deltaTime;
            rb.velocity = new Vector2(0f, dashForce);
        }
        else
        {
            start = false;
            isDashing = false;
            animator.SetBool("isVDashing", false); //stops animation
            
        }
    }

    void DashStart()
    {
        if (controls.Main.UpSpecial.ReadValue<float>() == 1 && isDashing == false && canDash == true && cc.canUse == true && ch.character == 1f) //checks to see if input has been pressed on frame, if they are already dashing and if they can dash
        {
            start = true;
            canDash = false; //removes dashing rights
            animator.SetBool("isVDashing", true); //starts animation
            isDashing = true; //shows its dashing
            cc.countdownTime = lagTime; //removes ability to use other methods of movement for a set amount of time
            dashTime = dashLength;
        }
    }
}

