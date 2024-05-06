using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpponentMovement : MonoBehaviour
{
    public float speed;
    public GameObject ball;

    private Rigidbody2D rb;
    private float movement;
    private bool canMove = true;

    void Start(){
        rb = GetComponent<Rigidbody2D>();
    }

    // Move to ball after player hits it or game just started
    // Return to middle after hitting the ball

    // Update is called once per frame
    void FixedUpdate()
    {
        if (canMove) {
            MoveToBall();
        }
        else {
            ReturnToMiddle();
        }

        rb.velocity = new Vector2(rb.velocity.x, movement * speed);
    }

    private void OnCollisionEnter2D(Collision2D coll){
        if (coll.gameObject.CompareTag("Ball")){
            canMove = false;
        }
    }

    public void SetCanMoveTrue(){
        canMove = true;
    }

    private void MoveToBall(){
        if ((int)transform.position.y < (int)ball.transform.position.y) {
            movement = 1;
        }
        else if ((int)transform.position.y > (int)ball.transform.position.y) {
            movement = -1;
        }
        else {
            movement *= 0.5f;
        }
    }

    private void ReturnToMiddle(){
        // Returns paddle back to middle
        if ((int)transform.position.y < 0) {
            movement = 1;
        }
        else if ((int)transform.position.y > 0) {
            movement = -1;
        }
        else {
            movement *= 0.5f;
        }
    }
}
