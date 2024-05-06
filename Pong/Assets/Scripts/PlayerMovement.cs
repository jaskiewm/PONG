using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed;
    public GameObject opp;

    private Rigidbody2D rb;
    private float movement;

    void Start(){
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        movement = Input.GetAxisRaw("Vertical2");

        if (movement == 0) {
            movement = Input.GetAxisRaw("Vertical");
        }

        rb.velocity = new Vector2(rb.velocity.x, movement * speed);
    }

    private void OnCollisionEnter2D(Collision2D coll) {
        // Allow opponent to move after we hit the ball
        if (coll.gameObject.CompareTag("Ball")){
            opp.GetComponent<OpponentMovement>().SetCanMoveTrue();
        }
    }
}
