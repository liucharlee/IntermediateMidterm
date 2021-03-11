using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trigger : MonoBehaviour
{
     public Transform cameraTransform; 
    Transform cameraFollowTarget; 


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
        if ( cameraFollowTarget != null ) { 
            cameraTransform.position = cameraFollowTarget.position + new Vector3( 0f, 0f, -10f ); 
        }
    }

    void OnTriggerExit2D(Collider2D activator) {
        // if this object exited the trigger, stop making the camera follow it
        if ( activator.transform == cameraFollowTarget ) {
            cameraFollowTarget = null; 
        }
    }
}
