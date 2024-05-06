using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.GraphicsBuffer;

public class BallRespawn : MonoBehaviour
{
    public Rigidbody2D ball;
    public GameObject opp;

    public void ballReset()
    {
        // Allow opponent movement again
        opp.GetComponent<OpponentMovement>().SetCanMoveTrue();

        // Restarts ball position to (0,0) and sets speed to 0
        respawnBallPos();

        // Coroutine to ensure the ball doesn't move immediately after respawn
        StartCoroutine(waitForSeconds());
    }

    IEnumerator waitForSeconds()
    {
        // Pause ball movement for 3 seconds
        yield return new WaitForSeconds(3);

        // Calls the ball start function to move the ball
        ball.GetComponent<BallMovement>().ballStart();
    }

    private void respawnBallPos()
    {
        ball.velocity = Vector2.zero; // Set ball velocity to 0
        ball.transform.position = new Vector2(0, 0); // Set ball position to (0,0)
    }
}
