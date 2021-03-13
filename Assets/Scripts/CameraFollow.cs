using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
     public Transform cameraTransform; 
     Transform cameraFollowTarget; 

    void Update() {
        
        cameraFollowTarget = gameObject.transform; // start camera following this object
        
        cameraTransform.position = cameraFollowTarget.position + new Vector3( 0f, 10f, -39f ); // z:-10 is extra camera offset
    }
}
