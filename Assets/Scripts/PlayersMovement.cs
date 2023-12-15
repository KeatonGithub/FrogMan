using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class PlayersMovement : MonoBehaviour
{
   private Rigidbody2D rb2d;
   public BoxCollider2D coll;
   [SerializeField] private Animator anim; //Serialized field lets us change values in unity without it having to be public
   [SerializeField] private SpriteRenderer sprite;  
   private float moveSpeed = 7f;
   private float jumpForce = 14f;
   private float dirX = 0f;
   [SerializeField] private LayerMask groundjumping;

    // Start is called before the first frame update
   private void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
        coll = GetComponent<BoxCollider2D>();
        anim = GetComponent<Animator>();
        sprite = GetComponent<SpriteRenderer>();   
    }

    // Update is called once per frame
   private void Update()
    {
        dirX = Input.GetAxisRaw("Horizontal");
        rb2d.velocity = new Vector2 (dirX * moveSpeed, rb2d.velocity.y);

        if (Input.GetButtonDown("Jump") && IsColliding()) //When Space bar is pressed you jump!
        {
            GetComponent<Rigidbody2D>().velocity = new Vector2(0, jumpForce);
        }
        UpdateAnimationState();
    }

    private void UpdateAnimationState()
    {
        if (dirX > 0f)
        {
            anim.SetBool("running", true);
            sprite.flipX = false;
        }
        else if (dirX < 0f)
        {
            anim.SetBool("running", true);
            sprite.flipX = true;
        }
        else
        {
            anim.SetBool("running", false);
        }

    }

    private bool IsColliding()
    {
       return Physics2D.BoxCast(coll.bounds.center, coll.bounds.size, 0f, Vector2.down, .1f, groundjumping);
    }
}
