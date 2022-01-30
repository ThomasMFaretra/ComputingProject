using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HorizontalDash : MonoBehaviour
{
    [SerializeField] private ControlScheme controls;
    private Rigidbody2D rb;
    private PlayerControl pm;
    private CooldownControl cc;
    private Position pos;
    private Switch ch;
    public Animator animator;
    
    public float movementCooldown;
    public float gravityCooldown;

    public float dashForce;
    public float dashLength;
    private float dashTime;
    public float abilityCooldown;
    private float direction;

    public float thisDashCooldown;
    public float endCooldownTime;

    
    public bool isDashing = false;
    public bool canDash = false;
    private bool start;
    
    void Awake()
    {
        controls = new ControlScheme();
        controls.Main.Enable();
    }

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        pm = GetComponent<PlayerControl>();
        cc = GetComponent<CooldownControl>();
        pos = GetComponent<Position>();
        ch = GetComponent<Switch>();
    }

    void FixedUpdate()
    {
        EndCooldownCheck();
        CanDashReset();
        DashStart();
        if (start == true)
        {
            Dash();
        }
    }

    void EndCooldownCheck()
    {
        if (endCooldownTime > 0)
        {
            endCooldownTime -= Time.fixedDeltaTime;
        }
    }

    void CanDashReset()
    {
        if (pos.isGrounded == true) //Resets canDash (allows another dash)
        {
            canDash = true;
        }
    }

    void DashStart()
    {
        if (controls.Main.SideSpecial.ReadValue<float>() == 1f && isDashing == false && canDash == true && cc.canUse == true && ch.character == 1f && endCooldownTime <= 0)
        {
            dashTime = dashLength;
            start = true;
            canDash = false;
            isDashing = true;
            cc.gravityTime = dashLength + gravityCooldown; //disable gravity
            cc.countdownTime = dashLength + movementCooldown; //disables movement
            cc.canUseTime = dashLength + abilityCooldown; //disables abilities
            animator.SetBool("isHDashing", true); //starts animation
            if (controls.Main.Move.ReadValue<float>() > 0)
            {
                direction = 1;
            }
            else
            {
                direction = -1;
            }
        }
    }

    void Dash()
    {
        if (dashTime > 0)
        {
            dashTime -= Time.fixedDeltaTime;
            rb.velocity = new Vector2(direction * dashForce, 0f);
        }
        else
        {
            isDashing = false;
            cc.gravity = true;
            start = false;
            animator.SetBool("isHDashing", false); //ends animation
            endCooldownTime = thisDashCooldown;
        }
    }
}
