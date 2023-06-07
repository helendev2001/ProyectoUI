using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ben10_Player : MonoBehaviour
{

   [SerializeField] public float runSpeed = 2;
    Rigidbody2D rb2D; 
    SpriteRenderer spriteBen10;
    Animator animator;
    //private Vector2 moveInput;
    
    // Start is called before the first frame update
    void Awake()
    {

        rb2D = GetComponent<Rigidbody2D>();
        spriteBen10 = GetComponent<SpriteRenderer>();
        animator = GetComponent<Animator>();
    }
    private void Update()
    {
        if(Input.GetKey("space"))
        {
            animator.SetTrigger("Golpear");
        }

    }

    // Update is called once per frame
    void FixedUpdate()
    {

        float horizontal = Input.GetAxisRaw("Horizontal");
        float vertical = Input.GetAxisRaw("Vertical");

        rb2D.velocity= new Vector2(horizontal, vertical)*runSpeed;
        
        if(Mathf.Abs(rb2D.velocity.magnitude)>0)
        {
            animator.SetBool("Caminar", true);
        }
        else
        {
            animator.SetBool("Caminar", false);
        }




        if (horizontal > 0)
        {
            spriteBen10.flipX = false;
        }
        else if (horizontal < 0)
        {
            spriteBen10.flipX = true;
        }
    }

}
