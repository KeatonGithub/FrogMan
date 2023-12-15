using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

public class Stomp : MonoBehaviour
{

    public float bounce; // declare value for how high the player flies
    public Rigidbody2D rigBod2d; //delcare the collider for the FrogMans feet
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void OnTriggerEnter2D(Collider2D Goomba) //setting up the player collision with the slime
    {
        if (Goomba.CompareTag("Slime")) //when player collides with the Slime object delete that object
        {
            Destroy(Goomba.gameObject);//destroys the game slime object
            rigBod2d.velocity = new Vector2(rigBod2d.velocity.x,bounce); //when player collides with object bonce upwards
        }
    }
}
