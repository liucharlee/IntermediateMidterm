using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformerGroundedTrigger : MonoBehaviour
{
    //need a reference to the PlatformerCharacter script, or else we can't talk to it
    public PlatformerCharacter myCharacter; // public: assign in Inspector

   
    void OnTriggerStay2D(Collider2D activator) {
        myCharacter.isGrounded = true;
    }

    
    void OnTriggerExit2D(Collider2D activator) {
        myCharacter.isGrounded = false;
    }
}
