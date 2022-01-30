using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StallAndFall : MonoBehaviour
{
    private Rigidbody2D rb;
    private CooldownControl cc;
    private Position pos;
    private Switch ch;
    public Animator animator;

    public float fallSpeed;
    public float stallLength;
    private float stallTimer;
    public float upwardsStallVector;
    public float endLag;

    public bool isStalled;
    public bool isFalling;
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
        stallTimer = stallLength;
    }

    void Update()
    {
        if (start == false)
        {
            Starter();
        }
        else
        {
            Fall();
        }
    }

    void Starter()
    {
        if (controls.Main.DownSpecial.ReadValue<float>() == 1 && pos.isGrounded == false && start == false && cc.canUse == true && ch.character == 1f)
        {
            start = true;
            cc.countdownTime += endLag;
        }

    }

    void Fall() 
    {
        if (stallTimer > 0)
        {
            cc.canUseTime += Time.deltaTime;
            cc.countdownTime += Time.deltaTime;
            stallTimer -= Time.deltaTime;
            rb.velocity = new Vector2(0f, upwardsStallVector);
            cc.gravity = false;
            animator.SetBool("isSandF", true); //starts animation
        }
        else
        {
            cc.gravity = true;
            cc.canUseTime += Time.deltaTime;
            cc.countdownTime += Time.deltaTime;
            rb.velocity = new Vector2(0f, -(fallSpeed));
            isFalling = true;
        }
        if (pos.isGrounded == true)
        {
            start = false;
            isFalling = false;
            stallTimer = stallLength;
            animator.SetBool("isSandF", false); //ends animation
        }
    }
}
