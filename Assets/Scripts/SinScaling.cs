using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SinScaling : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 vec = new Vector3(Mathf.Sin(Time.time)*2f, Mathf.Sin(Time.time)*30f, Mathf.Sin(Time.time)*20f);
 
         transform.localScale = vec;
    }
}
