using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trigger : MonoBehaviour
{
     public Transform cameraTransform; // "public" = it will be exposed in the Unity editor inspector
    Transform cameraFollowTarget; // no public = private, it will NOT be exposed to the Unity editor inspector

    // see https://docs.unity3d.com/ScriptReference/MonoBehaviour.OnTriggerEnter2D.html
    // automatically happen when something with a Rigidbody2D enters this trigger
    void OnTriggerEnter2D(Collider2D activator) {
        //if ( activator.transform == cameraFollowTarget ) {
        //cameraFollowTarget = null; // empty out the var... see Update()
       // }
        
        Debug.Log(activator.name + " entered this trigger!");
        cameraFollowTarget = activator.transform; // start camera following this object

        //GameObject.Find("Ball").GetComponent<CameraFollow>().enabled = false;
        
        
        //GameObject.Find("Ball").SetActive(false);
       
        //GameObject.Find("Ball").GetComponent(cameraFollowTarget).enabled = false;

       //GameObject varGameObject = GameObject.Find("Ball");
       //varGameObject.GetComponent<CameraFollow>().enabled = false;  // turn off the previous camera follow 
    }

    void Update() {
        // every frame, move the camera to follow the target...
        if ( cameraFollowTarget != null ) { // ... but only if we have a target to follow, and the var isn't empty
            cameraTransform.position = cameraFollowTarget.position + new Vector3( 0f, 0f, -10f ); // z:-10 is extra camera offset
        }
    }

    // see https://docs.unity3d.com/ScriptReference/MonoBehaviour.OnTriggerExit2D.html
    // automatically fires when something with a Rigidbody2D exits the trigger
    void OnTriggerExit2D(Collider2D activator) {
        // if this object exited the trigger, stop making the camera follow it
        if ( activator.transform == cameraFollowTarget ) {
            cameraFollowTarget = null; // empty out the var... see Update()
        }
    }
}
