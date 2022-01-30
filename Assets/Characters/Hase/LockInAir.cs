using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LockInAir : MonoBehaviour
{
    private Rigidbody2D rb;
    private CooldownControl cc;
    private Position pos;
    private Switch ch;
    private Animator ani;

    public float freezeLength;
    private float freezeTime;
    public float endLag;

    public float moveCooldown;
    private float cooldown;


    public float freezeCount;
    [SerializeField] float freezeCounter;

    public float horizontalSpeed;
    public float verticalSpeed;

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
        ani = GetComponent<Animator>();
        freezeTime = freezeLength;
        freezeCounter = freezeCount;
    }

    void Update()
    {
        GroundCheck();
        if (start == false)
        {
            StartCheck();
        }
        else
        {
            Lock();
        }
    }

    void GroundCheck()
    {
        if (pos.isGrounded == true) //Resets canLock(allows another dash)
        {
            freezeCounter = freezeCount;
        }
    }

    void StartCheck()
    {
        if (controls.Main.DownSpecial.ReadValue<float>() == 1 && pos.isGrounded == false && start == false && cc.canUse == true && ch.character == 2f && freezeCounter > 0)
        {
            start = true;
            cc.countdownTime += endLag; //adds movement endlag
            freezeCounter -= 1;
        }
        else
        {
            freezeTime = 0f;
        }
    }

    void Lock()
    {
        if (controls.Main.NeutralSpecial.ReadValue<float>() == 1 && freezeTime <= freezeLength)
        {
            ani.SetBool("isLocked", true); //Starts the freeze animation
            freezeTime = cc.canUseTime += Time.deltaTime;
            cc.countdownTime += Time.deltaTime;
            rb.velocity = new Vector2(0f, 0f);
            cc.gravity = false; //turns gravity off
        }
        else
        {
            cc.gravity = true; ; //turns gravity back on
            Vector2 force = controls.Main.Direction.ReadValue<Vector2>(); //sets the force equal to the value of Direction
            rb.AddForce(new Vector2(-force.x * horizontalSpeed, -force.y * verticalSpeed), ForceMode2D.Force);
            start = false;
            ani.SetBool("isLocked", false); //ends the freeze animation
        }
    }
}
