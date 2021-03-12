using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseResume : MonoBehaviour
{
    void Start ()
    {
        //Start Game Paused
        Time.timeScale = 0;
    }

    void Update ()
    {
        //Resume Game
        if ( Input.GetKey(KeyCode.RightArrow )) {
            Time.timeScale = 1;

        //Destroy(Text);
        }
        
    }
}
