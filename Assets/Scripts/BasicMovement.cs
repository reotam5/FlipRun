using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class BasicMovement : MonoBehaviour
{
    public Animator animator;
    public Variables var;
    public Rigidbody2D rb2D;
    public SpriteRenderer spriteRenderer;

    // Update is called once per frame
    void FixedUpdate()
    {
        //always running
        if (var.forward)
        {
            //flip sprite image
            spriteRenderer.flipX = false;


            if (var.down)
            {
                rb2D.velocity = new UnityEngine.Vector2(var.speed,rb2D.velocity.y);
                animator.SetFloat("speed", 1);
            }
            else
            {
                rb2D.velocity = new UnityEngine.Vector2(var.speed, rb2D.velocity.y);
                animator.SetFloat("speed", 1);
            }
        }
        else
        {
            //flip sprite image
            spriteRenderer.flipX = true;


            if (var.down)
            {
                rb2D.velocity = new UnityEngine.Vector2(-var.speed, rb2D.velocity.y);
                animator.SetFloat("speed", 1);
            }
            else
            {
                rb2D.velocity = new UnityEngine.Vector2(-var.speed, rb2D.velocity.y);
                animator.SetFloat("speed", 1);
            }
        }




    }
    void Update()
    {

        //set gravity scale
        if (var.down)
        {
            rb2D.gravityScale = var.gravityScale;
        }
        else
        {
            rb2D.gravityScale = -var.gravityScale;
        }


        //jump
        if (Input.GetKeyDown(KeyCode.Space) || (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Began && Input.GetTouch(0).position.x > Screen.width/2))
        {
            if (!var.jumping && var.currentCharge - 1f >= 0)
            {
                if (var.down)
                {
                    //rb2D.AddForce(transform.up * 15, ForceMode2D.Impulse);
                    rb2D.velocity = new UnityEngine.Vector2(rb2D.velocity.y, var.jumpforce);
                }
                else
                {
                    rb2D.velocity = new UnityEngine.Vector2(rb2D.velocity.y, -var.jumpforce);
                }
                var.jumping = true;
                var.currentCharge = var.currentCharge - 1f;
            }
        }
        

        //flip gravity
        if (Input.GetKeyDown(KeyCode.LeftShift) || (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Began && Input.GetTouch(0).position.x < Screen.width / 2))
        {
            if (!var.FlipGravity && var.currentCharge - 3f >= 0)
            {
                if (var.down)
                {
                    rb2D.AddForce(transform.up * 100, ForceMode2D.Impulse);

                    //flip sprite image
                    spriteRenderer.flipY = true;


                    var.down = false;
                }
                else
                {
                    rb2D.AddForce(transform.up * -100, ForceMode2D.Impulse);

                    //flip sprite image
                    spriteRenderer.flipY = false;


                    var.down = true;
                }
                var.FlipGravity = true;
                Debug.Log("gravity flipped");
                
                var.currentCharge = var.currentCharge - 3f;
            }
        }

    }
}
