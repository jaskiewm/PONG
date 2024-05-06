using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class BallMovement : MonoBehaviour
{
    public float ballSpeed = 10f;
    private int ballDir;

    public Rigidbody2D ball;

    void Start()
    {
        ball.GetComponent<BallRespawn>().ballReset();
    }

    private void Update()
    {
        // If the ball goes past the top / bottom wall
        if (ball.position.y > 5 || ball.position.y < -5)
        {
            ball.velocity = new Vector2(0,0); //Sets velocity to zero
            ball.GetComponent<BallRespawn>().ballReset(); // Respawn ball script
        }

        // If Else statements to ensure ball speed is always below 40
        if(ball.velocity.x > 30)
        {
            ball.velocity = new Vector2 (30, ball.velocity.y);
        }
        if (ball.velocity.y > 30)
        {
            ball.velocity = new Vector2(ball.velocity.y,30);
        }

    }

    public void ballStart()
    {
        if (Random.Range(0, 2) == 0)
        {
            ballDir = -1; // Move ball left
        }
        else
        {
            ballDir = 1; // Move ball right
        }

        int yDirection = Random.Range(-1, 2);

        // Vector2 for setting that start direction of the ball
        Vector2 newDirection = new Vector2(ballDir, Random.Range(0f,0.6f) * yDirection);

        // Add force to ball when it spawns
        ball.AddForce(newDirection * ballSpeed);
    }

}