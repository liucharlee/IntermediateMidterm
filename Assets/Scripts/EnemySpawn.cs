using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawn : MonoBehaviour
{
    public Rigidbody2D myEnemyPrefab; // public = in Inspector, Rigidbody2D = for our convenience
    
    public float spawnTimer;
    public float spawnTimerReset; //reset timer value

    // Start is called before the first frame update
    void Start()
    {
        spawnTimer = 3f/Time.deltaTime;
        spawnTimerReset = 3f/Time.deltaTime;
    }

    // Update is called once per frame
    void Update()
    {
        spawnTimer--;

        if(spawnTimer <= 0){
            //spawn enemy above player position
            Instantiate( myEnemyPrefab, transform.position + new Vector3( Random.Range(-20f, 20f), Random.Range(30f, 50f), 0f ), Quaternion.identity );
            spawnTimer = spawnTimerReset;
        }
        
    }
}
