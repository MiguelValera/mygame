using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    public float runSpeed = 2f;

    public float jumpSpeed = 3f;

    Rigidbody2D rb2d;

    SpriteRenderer renderer;

    Animator animator;

    public float hightFallPlayer = 0.5f;

    public float lowJumpPlayer = 1f;

    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
        renderer = GetComponent<SpriteRenderer>();
        animator = GetComponent<Animator>();
    }

    
    void FixedUpdate()
    {
        Debug.Log(CheckGround.isGrounded);
        //<----------------Movement--------------------->
        if (Input.GetKey("d") || (Input.GetKey("right")))
        {
            rb2d.velocity = new Vector2(runSpeed, rb2d.velocity.y);
            renderer.flipX = false;
            animator.SetBool("Run", true);
        }
        else if (Input.GetKey("a") || (Input.GetKey("left")))
        {
            rb2d.velocity = new Vector2(-runSpeed, rb2d.velocity.y);
            renderer.flipX = true;
            animator.SetBool("Run", true);
        }
        else
        {
            rb2d.velocity = new Vector2(0, rb2d.velocity.y);
            animator.SetBool("Run", false);
        }
        //<----------------Movement--------------------->

        //<----------------Jump--------------------->
        if (Input.GetKey("space") || Input.GetKey("w") || Input.GetKey("up") && CheckGround.isGrounded)
        {
            rb2d.velocity = new Vector2(rb2d.velocity.x, jumpSpeed);
        }
        //<----------------Jump--------------------->

        //<----------------Check Jump animation--------------------->
        if (!CheckGround.isGrounded)
        {
            animator.SetBool("Jump", true);
            animator.SetBool("Run", false);
        }
        if (CheckGround.isGrounded)
        {
            animator.SetBool("Jump", false);
        }
        //<----------------Check Jump animation--------------------->

        //<----------------Better Jump--------------------->
        if (rb2d.velocity.y<0)
        {
            rb2d.velocity += (hightFallPlayer) * Physics2D.gravity.y * Time.deltaTime * Vector2.up;
        }
        if (rb2d.velocity.y>0 && !Input.GetKey("space"))
        {
            rb2d.velocity += (lowJumpPlayer) * Physics2D.gravity.y * Time.deltaTime * Vector2.up;
        }

    }
    //<-----------------Platforms logic--------------------->
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Platform")
        {
            transform.parent = collision.transform;
        }
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Platform")
        {
            transform.parent = null;
        }
    }
    //<-----------------Platforms logic--------------------->

}
