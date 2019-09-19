using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class MovePlayer : MonoBehaviour {

    private Rigidbody2D playerRigid;
    public float speed = 1f;
    private Vector2 orgVector;
    public FixedJoystick joystick;

    //public float jumpHeight = 3f;
    public static bool isJumping = false;

    void Start() {
        playerRigid = GetComponent<Rigidbody2D>();
    }

    void FixedUpdate() {
        float localAxis = 0;
        float jumpHeight = 0;
        float axis = joystick.Horizontal;
        float axisUp = joystick.Vertical;

        if (axis >= .6f) {
            localAxis = 1;
        } else if (axis <= -.6f) {
            localAxis = -1;
        } else {
            localAxis = 0;
        }

        if (axisUp >= .6f && isJumping == false) {
            jumpHeight = 1.5f;
        } else {
            jumpHeight = 0;
        }

        Vector2 v2 = new Vector2(localAxis, jumpHeight);

        transform.Translate(v2 * speed * Time.fixedDeltaTime);

    }

    private void OnCollisionEnter2D(Collision2D collision) {
        if (collision.collider.tag == "Ground") {
            isJumping = false;
        }
    }

    private void OnCollisionExit2D(Collision2D collision) {
        if (collision.collider.tag == "Ground") {
            isJumping = true;
        }
    }
}
