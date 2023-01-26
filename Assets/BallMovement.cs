using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallMovement : MonoBehaviour
{
    private float speed = 8;
    string input;
    public Rigidbody2D rb;
    float lastYspeed = 0;

    public AudioSource jumpSound;

    // Start is called before the first frame update
    void Start()
    {
        input = "Horizontal"; 
        rb.velocity = new Vector2(0,0);       
    }

    // Update is called once per frame
    void Update()
    {
        //attempt at sceernwrap
        if (rb.position.x < -7.5)
            rb.position = new Vector2(7, rb.position.y);
        if (rb.position.x > 7.5)
            rb.position = new Vector2(-7, rb.position.y);
   
        //take horizontal input to move left or right
        float move = Input.GetAxis(input) * Time.deltaTime * speed;
        transform.Translate (move * Vector2.right);
        
        
        //set y velocity to 8 if up is pressed
        if (Input.GetKey("up") && rb.velocity.y == 0 && lastYspeed == 0) 
        {    
             jumpSound.Play();
             rb.velocity = new Vector2(rb.velocity.x, 7);
        }
        lastYspeed = rb.velocity.y;



        if (Input.GetKey("escape"))
             Application.Quit();
    }

}
