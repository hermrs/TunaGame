using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpAndMove : MonoBehaviour
{
    private Rigidbody2D rb2D;
    [SerializeField] public float moveSpeed;
    [SerializeField] public float jumpSpeed;
    private bool isJumping;
    private float moveH;
    private float moveV;
    // Start is called before the first frame update
    void Start()
    {
        moveSpeed = 2f;
        jumpSpeed = 10f;
        isJumping = false;
        rb2D = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        moveH = Input.GetAxisRaw("Horizontal");
        moveV = Input.GetAxisRaw("Vertical");
    }
    void FixedUpdate()
    {
        if(moveH > 0.1f || moveH < -0.1f) 
        {
            rb2D.AddForce(new Vector2(moveH * moveSpeed, 0),ForceMode2D.Impulse);
        }
        if (!isJumping && moveV > 0.1f )
        {
            rb2D.AddForce(new Vector2(0f,moveV * moveSpeed * 2),ForceMode2D.Impulse);
        }
    }
    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Platform")
        {
            isJumping = false;
        }
    }
    void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Platform")
        {
            isJumping = true;
        }
    }
}
