using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinaleTrigger : MonoBehaviour
{   
    public Transform cameraTransform; 

    // automatically happen when something with a Rigidbody2D enters this trigger
    void OnTriggerEnter2D(Collider2D activator) {
        //cameraTransform.position = new Vector3( 162f, -46f, -10f );


        Destroy(GameObject.Find("FinalePlatform"));

    }
}