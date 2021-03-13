using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformerCharacter : MonoBehaviour
{
    // object references
    Rigidbody2D myRigidbody; // stores a reference to the Rigidbody

    // object state
    float inputHorizontal;
    bool isJumping;
    public bool isGrounded; // set by PlatformerGroundedTrigger.cs
    bool isDashing;

    // tuning variables
    public float moveSpeed = 15f, jumpPower = 25f;
    
    void Start()
    {
        myRigidbody = GetComponent<Rigidbody2D>(); // cache the reference in Start to save us time and processing
    }

    // Update happens every RENDERING frame, this is also where input happens
    void Update()
    {
        // get left/right arrow keys to move left/right with a virtual joystick
        inputHorizontal = Input.GetAxis("Horizontal"); // a value from -1 to 1... -1 if left, +1 if right

        // press SPACE to jump... but only if we're standing on the ground
        if ( Input.GetButtonDown("Jump") && isGrounded == true ) {
            isJumping = true;
        }

        if ( Input.GetKeyDown(KeyCode.LeftShift)) {
            isDashing = true;
        }
    }

    // FixedUpdate happens every PHYSICS frame, at a fixed timestep
    // (technically, everything that happens here is framerate independent, so no real need for Time.deltaTime here)
    void FixedUpdate() {
        // we need to put the Y value back into itself to preserve vertical velocity (e.g. falling)
        myRigidbody.velocity = new Vector2( inputHorizontal * moveSpeed, myRigidbody.velocity.y );

        // if we need to do the jump, then add Y velocity
        if ( isJumping ) {
            myRigidbody.velocity = new Vector2( myRigidbody.velocity.x, jumpPower );
            isJumping = false;
        }

        if ( isDashing ) {
            myRigidbody.velocity = new Vector2( myRigidbody.velocity.x * 10f, myRigidbody.velocity.y);
            isDashing = false;
        }
    }

    void OnCollisionEnter2D(Collision2D col)
    {
        if(col.gameObject.tag == "Enemy"){
            Destroy(gameObject);
        }
    }
}

