using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//randomly swims around with its own free will!!
public class Fish : MonoBehaviour
{
    public Vector3 myDestination; // where the fish is swimming towards

    void Update()
    {
        // tell the fish to swim toward its destination
        Vector3 swimVector = myDestination - transform.position;
        transform.position += swimVector.normalized * Time.deltaTime;

        // tell the fish to point toward where it's going
        transform.up = swimVector.normalized;

    
        Debug.DrawLine( transform.position, myDestination, Color.yellow );
    }
}