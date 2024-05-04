using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {

    public float speed = 100f;
    private Rigidbody2D rb2d;

    // Start is called before the first frame update
    void Start() {
        rb2d = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update() {
        float moveVertical = Input.GetAxis("Vertical");
        rb2d.velocity = new Vector2(0, speed * moveVertical);
    }
}
