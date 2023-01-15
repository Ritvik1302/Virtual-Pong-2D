using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paddle2 : Paddle
{
    public Rigidbody2D ball;
   
    private void FixedUpdate()
    {
        if (ball.velocity.x>0f)
        {
            if(ball.position.y>transform.position.y)
            {
                rb.AddForce(Vector2.up*speed);
            }
           else if(ball.position.y<transform.position.y)
            {
                rb.AddForce(Vector2.down*speed);
            }
        }
        else
        {
            if(transform.position.y>0f)
            {
                rb.AddForce(Vector2.down*speed);
            }
            else if(transform.position.y<0f)
            {
                rb.AddForce(Vector2.up*speed);
            }
        }
    
    }
}
