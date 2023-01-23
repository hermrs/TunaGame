using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpAndMove : MonoBehaviour
{
    
    private Rigidbody2D rb2D;
    [SerializeField] public float moveSpeed;
    [SerializeField]  public float jumpSpeed;
    public Transform groundCheck;
    public float groundCheckRadius;
    public LayerMask groundLayer;
    private bool isTouchingGround;
    private float moveH;
    private float moveV;
    [SerializeField] private float direction;
    // Start is called before the first frame update
    void Start()
    {
       
        moveSpeed = 2f;
        jumpSpeed = 10f;
        
       
        rb2D = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        isTouchingGround = Physics2D.OverlapCircle(groundCheck.position, groundCheckRadius,groundLayer); 
        direction = Input.GetAxis("Horizontal");
        if (direction > 0f)
        {
            rb2D.velocity = new Vector2(direction * moveSpeed, rb2D.velocity.y);;
        }
        else if(direction < 0f)
        {
            rb2D.velocity=new Vector2(direction * moveSpeed, rb2D.velocity.y);;
        }
        else
        {
            rb2D.velocity = new Vector2(0, rb2D.velocity.y);
        }
        if (Input.GetButtonDown("Jump") && isTouchingGround)
        {
           rb2D.velocity=new Vector2(rb2D.velocity.x,jumpSpeed);
        }
    }
    
    
}
