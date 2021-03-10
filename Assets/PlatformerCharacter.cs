using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//character controller with basic movement and jumping
public class PlatformerCharacter : MonoBehaviour
{
   
    Rigidbody2D myRigidbody; // stores a reference to the Rigidbody

    float inputHorizontal;
    bool isJumping;
    public bool isGrounded; // set by PlatformerGroundedTrigger.cs


    public float moveSpeed = 15f, jumpPower = 25f;
    
    void Start()
    {
        myRigidbody = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        // get left/right arrow keys to move left/right with a virtual joystick
        inputHorizontal = Input.GetAxis("Horizontal");

        // press SPACE to jump... but only if we're standing on the ground
        if ( Input.GetButtonDown("Jump") && isGrounded == true ) {
            isJumping = true;
        }
    }

    void FixedUpdate() {
        // we need to put the Y value back into itself to preserve vertical velocity
        myRigidbody.velocity = new Vector2( inputHorizontal * moveSpeed, myRigidbody.velocity.y );

        // if we need to do the jump, then add Y velocity
        if ( isJumping ) {
            myRigidbody.velocity = new Vector2( myRigidbody.velocity.x, jumpPower );
            isJumping = false;
        }
    }
}
