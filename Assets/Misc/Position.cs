using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Position : MonoBehaviour
{
    // isGrounded variables
    public Animator animator;
    private BoxCollider2D boxCollider2d;
    public LayerMask whatIsGround;
    public bool isGrounded;
    // lastDirection variables
    private float direction;
    public float lastDirection;

    void Start()
    {
        boxCollider2d = GetComponent<BoxCollider2D>();
        lastDirection = 1f; //abritrarily sets last direction to left so it doesn't break (cant be 0)
    }
    
    void Update()
    {
        isGrounded = Physics2D.BoxCast(boxCollider2d.bounds.center, boxCollider2d.bounds.size, 0f, Vector2.down, 0.1f, whatIsGround); //checks if object is on the ground
        animator.SetBool("isGrounded", isGrounded);
    }

    void FixedUpdate()
    {
        // Last Direction controller

        direction = Input.GetAxisRaw("Horizontal");
        if (direction != lastDirection && direction != 0)
        {
            lastDirection = direction;
        }
    }
}
