using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour
{
    public Vector2 moveVector;
    public float speed = 5f;
    private Rigidbody2D rb;
    private bool isFacingRight = true;
    public Animator anim;
    public int jumpForce = 10;
    public bool onGround;
    public LayerMask Ground;
    public float grounCheckRadius=0.3f;
    public Transform groundcheck;
    private Vector3 respawn;
    SpriteRenderer spi;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
        respawn = transform.position;

    }

    
    void Update()
    {
        moveVector.x = Input.GetAxisRaw("Horizontal");
        rb.velocity = new Vector2(moveVector.x*speed,rb.velocity.y);
        anim.SetFloat("move",Mathf.Abs(moveVector.x));

        if (moveVector.x<0 && isFacingRight)
        {
            Flip();
        }
        if (moveVector.x>0 && !isFacingRight)
        {
            Flip();
        }
        if(onGround && Input.GetKeyDown(KeyCode.Space))
        {
            rb.velocity = new Vector2(rb.velocity.x,jumpForce);
            /*anim.SetBool("jump", onGround);*/
        }
        ChekingGround();

    }
    
    void Flip()
    {
        isFacingRight = !isFacingRight;
        transform.Rotate(0f, 180f, 0f);
/*        Vector3 theScale = transform.localScale;
        theScale.x *= -1;
        transform.localScale = theScale;*/
    }
    void ChekingGround()
    {
        onGround = Physics2D.OverlapCircle(groundcheck.position,grounCheckRadius,Ground);

    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "deadzone")
        {
            transform.position = respawn;
        }
        else if (collision.tag == "checkpoint")
        {
            respawn = transform.position;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("platform"))
        {
            this.transform.parent = collision.transform;

        }
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("platform"))
        {
            this.transform.parent = null;

        }
    }
}
