using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// let me use the mouse to aim a cannon, 
// and left-click to shoot a projectile ball


public class ProjectileLaunch : MonoBehaviour
{
    public float rotationSpeed = 180f; 
    public float shootForce = 1000f; 
    public Rigidbody2D myProjectilePrefab; 

    void Update()
    {
 

        // mouse aiming: always face towards the mouse cursor position
        Vector3 mouseCursorPosInWorld = Camera.main.ScreenToWorldPoint( Input.mousePosition );
        Vector2 fromPlayerToMouseCursor = mouseCursorPosInWorld - transform.position;
        // rotate to align my "right" with vec toward mouse cursor
        transform.right = fromPlayerToMouseCursor; 
        Debug.DrawRay( transform.position, fromPlayerToMouseCursor, Color.cyan );


        // left-click to shoot a projectile out of the cannon
        if ( Input.GetMouseButtonDown(0) ) { 
            Rigidbody2D myNewClone = Instantiate( myProjectilePrefab, transform.position + transform.right * 2, Quaternion.identity );
            // add force in the direction of this cannon's current "down" vector
            myNewClone.AddForce( transform.right * shootForce );
        }

    }

}
