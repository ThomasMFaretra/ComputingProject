using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    [SerializeField] private ControlScheme controls;
    private Rigidbody2D rb;
    private Position pos;
    private SpriteRenderer spr;
    private Animator ani;
    private ControlScheme cont;

    public float movementSpeed = 11f;

    public float JumpSpeed;
    public float JumpTime;
    private float JumpCounter;

    public float direction = 0f;

    public float lastFacedDirection = 1f;
    public bool isJumping;

    void Awake()
    {
        controls = new ControlScheme();
        controls.Main.Enable();
    }

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        pos = GetComponent<Position>();
        spr = GetComponent<SpriteRenderer>();
        ani = GetComponent<Animator>();
    }

    void Update()
    {
        Rotate();
    }

    void FixedUpdate()
    {
        Jump();
        Direction();
    }

    void Rotate()
    {
        if (pos.lastDirection != lastFacedDirection)
        {
            lastFacedDirection = pos.lastDirection;
            if (lastFacedDirection < 0)
            {
                spr.flipX = true;
            }
            else
            {
                spr.flipX = false;
            }
        }
    }

    void Jump()
    {
        if (pos.isGrounded == true && controls.Main.Jump.ReadValue<float>() == 1f) //Jumping Script
        {
            isJumping = true;
            JumpCounter = JumpTime;
            ani.SetBool("isJumping", true);
        }

        if (isJumping == true)
        {
            if (controls.Main.Jump.ReadValue<float>() == 1f && JumpCounter > 0)
            {
                rb.velocity = Vector2.up * JumpSpeed;
                JumpCounter -= Time.deltaTime;
            }
            else
            {
                isJumping = false;
                ani.SetBool("isJumping", false);
            }
        }     
    }

    void Direction()
    {
        direction = controls.Main.Move.ReadValue<float>();
        rb.velocity = new Vector2(direction * movementSpeed, rb.velocity.y);
        ani.SetFloat("speed", Mathf.Abs(direction));
    }
    

}
