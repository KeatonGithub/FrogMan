using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class PlayersMovement : MonoBehaviour
{
   private Rigidbody2D rb2d;//declare the RigidBody2D as a variable
   public BoxCollider2D colliders;//declaring colliders as a variable
    //Serialized field lets us change values in unity without it having to be public
   [SerializeField] private Animator animations; //uses animator function for sprites
   [SerializeField] private SpriteRenderer sprite;//uses spriterenderer function for sprites
   private float moveSpeed = 7f;//movespeed
   private float jumpForce = 14f;//jumpspeed
   private float directionOfX = 0f;//direction
   [SerializeField] private LayerMask groundjumping;//lets us now if the player is on the ground layer

    // Start is called before the first frame update
   private void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();//Get and declare the Rigidbody2D, BoxCollider, Animator, and SpriteRenderer
        colliders = GetComponent<BoxCollider2D>();
        animations = GetComponent<Animator>();
        sprite = GetComponent<SpriteRenderer>();   
    }

    // Update is called once per frame
   private void Update()
    {
        directionOfX = Input.GetAxisRaw("Horizontal");//gets the input for x
        rb2d.velocity = new Vector2 (directionOfX * moveSpeed, rb2d.velocity.y); //lets us customize the velcity

        if (Input.GetButtonDown("Jump") && IsColliding()) //When Space bar is pressed you jump! Also checks if you are on the ground so you can jump
        {
            GetComponent<Rigidbody2D>().velocity = new Vector2(0, jumpForce);//Causes the player to jump up with the height of the jumpForce with rigidbody physics bring it down
        }

        UpdateAnimationState();//self explanitory
    }

    private void UpdateAnimationState() //this lets us change the direction of the animations depending on the direction or if they ar running
    {
        if (directionOfX > 0f)
        {
            animations.SetBool("running", true);//running animation
            sprite.flipX = false;
        }
        else if (directionOfX < 0f)
        {
            animations.SetBool("running", true);//flips the running sprite
            sprite.flipX = true;
        }
        else
        {
            animations.SetBool("running", false); //play idle animation
        }

    }

    private bool IsColliding()//this function is here so that you cannot spam jump to fly so it checks if the player is colliding with the terrain
    {
       return Physics2D.BoxCast(colliders.bounds.center, colliders.bounds.size, 0f, Vector2.down, .1f, groundjumping);
    }
}
