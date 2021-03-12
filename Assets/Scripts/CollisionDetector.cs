using System.Collections;
using System.Collections.Generic;
using UnityEngine;

 public class CollisionDetector : MonoBehaviour {
 
     void OnCollisionEnter(Collision col)
     {
         if (col.gameObject.tag == "EnemyCircle")
         {
             Destroy(GameObject.Find("Character"));
         }
     }
 }
