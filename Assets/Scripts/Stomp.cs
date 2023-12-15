using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

public class Stomp : MonoBehaviour
{

    public float bounce;
    public Rigidbody2D rigBod2d;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Slime"))
        {
            Destroy(other.gameObject);
            rigBod2d.velocity = new Vector2(rigBod2d.velocity.x,bounce);
        }
    }
}
