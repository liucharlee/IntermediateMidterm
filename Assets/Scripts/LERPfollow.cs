using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LERPfollow : MonoBehaviour
{
    //public Transform ObjectToFollow;
    public float LerpScale=5f;
    
    public GameObject player;
    public Transform playerTransform;


    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("Player");
        playerTransform = player.GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector3.Lerp(transform.position, playerTransform.position, LerpScale * Time.deltaTime);
    }
}
