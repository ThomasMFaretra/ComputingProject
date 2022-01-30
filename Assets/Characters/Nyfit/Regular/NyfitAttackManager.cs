using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NyfitAttackManager : MonoBehaviour
{
    private Animator ani;
    private Position pos;
    private ControlScheme cont;
    private CooldownControl cc;
    private Rigidbody2D rb;
    private ControlScheme controls;

    public float fireRate = 0.2f;
    private float nextFire = 0f;

    //--// Dash Attack //--

    private bool dashStart = false;
    public float dashFireRate;
    private float dashNextFire = 0f;
    public float dashVelocity;
    public float dashMovementLag;
    public float dashAbilityLag;

    //--// Forward Tilt //--

    public float forwardTiltFireRate;
    private float forwardTiltNextFire = 0f;
    public float forwardTiltMovementLag;
    public float forwardTiltAbilityLag;

    //--// Up Tilt //--

    public float upTiltFireRate;
    private float upTiltNextFire = 0f;
    public float upTiltMovementLag;
    public float upTiltAbilityLag;

    //--// Down Tilt //--

    public float downTiltFireRate;
    private float downTiltNextFire = 0f;
    public float downTiltMovementLag;
    public float downTiltAbilityLag;


    void Awake()
    {
        controls = new ControlScheme();
        controls.Main.Enable();
    }

    void Start()
    {
        ani = GetComponent<Animator>();
        cc = GetComponent<CooldownControl>();
        rb = GetComponent<Rigidbody2D>();
        pos = GetComponent<Position>();
    }

    void Update()
    {
        //DashAttack();
        ForwardTilt();
        UpTilt();
        DownTilt();
        SideAir();
        UpAir();
        DownAir();
    }

    //-----------------// Dash Attack //----------------------------

    void DashAttack()
    {
        if (pos.isGrounded == true && controls.Main.DashAttack.ReadValue<float>() == 1f && controls.Main.Move.ReadValue<float>() != 0 && Time.time > dashNextFire && Time.time > nextFire)
        {
            dashStart = true;
            rb.velocity = new Vector2(dashVelocity * pos.lastDirection, rb.velocity.y);
        }

        if (dashStart == true)
        {
            ani.SetTrigger("Dash_Attack");
            dashNextFire = Time.time + dashFireRate;
            nextFire = Time.time + fireRate;
            cc.countdownTime += dashMovementLag;
            cc.canUseTime += dashAbilityLag;
            dashStart = false;
        }
    }

    //------------------// Forward Tilt //---------------------------

    void ForwardTilt()
    {
        if (pos.isGrounded == true && controls.Main.ForwardTilt.ReadValue<float>() == 1f && controls.Main.Move.ReadValue<float>() != 0 && Time.time > forwardTiltNextFire && Time.time > nextFire)
        {
            //rb.velocity = Vector2.zero;
            ani.SetTrigger("Forward_Tilt");
            forwardTiltNextFire = Time.time + forwardTiltFireRate;
            nextFire = Time.time + fireRate;
            cc.countdownTime += forwardTiltMovementLag;
            cc.canUseTime += forwardTiltAbilityLag;
        }
    }

    //--------------------// Jab Chain //---------------------------

    void JabChain()
    {

    }

    //---------------------// Up Tilt //----------------------------

    void UpTilt()
    {
        if (pos.isGrounded == true && controls.Main.UpTilt.ReadValue<float>() == 1f && controls.Main.Move.ReadValue<float>() == 0 && Time.time > upTiltNextFire && Time.time > nextFire)
        {
            rb.velocity = Vector2.zero;
            ani.SetTrigger("Up_Tilt");
            upTiltNextFire = Time.time + upTiltFireRate;
            nextFire = Time.time + fireRate;
            cc.countdownTime += upTiltMovementLag;
            cc.canUseTime += upTiltAbilityLag;
        }
    }

    //--------------------// Down Tilt //---------------------------

    void DownTilt()
    {
        if (pos.isGrounded == true && controls.Main.DownTilt.ReadValue<float>() == 1f && controls.Main.Move.ReadValue<float>() == 0 && Time.time > downTiltNextFire && Time.time > nextFire)
        {
            rb.velocity = Vector2.zero;
            ani.SetTrigger("Down_Tilt");
            downTiltNextFire = Time.time + downTiltFireRate;
            nextFire = Time.time + fireRate;
            cc.countdownTime += downTiltMovementLag;
            cc.canUseTime += upTiltAbilityLag;
        }
    }

    // Aerial

    void SideAir()
    {
        if (pos.isGrounded == false && controls.Main.ForwardTilt.ReadValue<float>() == 1f && controls.Main.Move.ReadValue<float>() != 0 && Time.time > nextFire)
        {
            ani.SetTrigger("Forward_Tilt");
            forwardTiltNextFire = Time.time + forwardTiltFireRate;
            nextFire = Time.time + fireRate;
            cc.canUseTime += forwardTiltAbilityLag;
        }
    }

    void DownAir()
    {
        if (pos.isGrounded == false && controls.Main.DownTilt.ReadValue<float>() == 1f && controls.Main.Move.ReadValue<float>() == 0 && Time.time > nextFire)
        {
            ani.SetTrigger("Down_Tilt");
            nextFire = Time.time + fireRate;
            cc.countdownTime += downTiltMovementLag;
            cc.canUseTime += upTiltAbilityLag;
        }
    }

    void UpAir()
    {
        if (pos.isGrounded == false && controls.Main.UpTilt.ReadValue<float>() == 1f && controls.Main.Move.ReadValue<float>() == 0 && Time.time > nextFire)
        {
            ani.SetTrigger("Up_Tilt");
            nextFire = Time.time + fireRate;
            cc.countdownTime += upTiltMovementLag;
            cc.canUseTime += upTiltAbilityLag;
        }
    }
}
