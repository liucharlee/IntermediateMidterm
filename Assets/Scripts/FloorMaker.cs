using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FloorMaker : MonoBehaviour {

int FloorCounter = 0; // count how many floor tiles this FloorMaker has instantiated

//	Declare a public Transform called floorPrefab, assign the prefab in inspector;
public Transform floorPrefab;

public Transform floorMakerPrefab;

public static int globalTileCount;

public float[] floorEventNumber; //Assign each floor with a random eventNumber and show in inspector
public float[] sortedFloorEventNumber; //sorted version

	void Start(){
		float[] floorEventNumber = new float[150];
		float[] sortedFloorEventNumber = new float[150];
	}
	
	void Update () {
//		If counter is less than 150, then:
		if ( FloorCounter < 150 ) {
//			Generate a random number from 0.0f to 1.0f;
			float randomNumber = Random.Range(0.0f, 1.0f);
//			If random number is less than 0.25f, then rotate myself 90 degrees on Z axis;
//				... Else if number is 0.25f-0.5f, then rotate myself -90 degrees on Z axis;
//				... Else if number is 0.99f-1.0f
			if ( randomNumber < 0.20f ) { 
                transform.Rotate(0, 0, 90);
            } else if (0.20f < randomNumber && randomNumber < 0.50f) {
				transform.Rotate(0, 0, -90);
			} else if (0.999f < randomNumber && randomNumber < 1.0f) {
				//Instantiate( floorMakerPrefab, transform.position, Quaternion.Euler(0, 0, 0) );
			}

//			Instantiate a floorPrefab clone at current position;
			Instantiate( floorPrefab, transform.position, Quaternion.Euler(0, 0, 0) );


			//Assign each floor with a random eventNumber
			//float[] floorEventNumber = new float[150];
			floorEventNumber[FloorCounter] = Random.Range(0, 10);
			Debug.Log("floor" + FloorCounter + "floorEventNumber:" + floorEventNumber[FloorCounter]);


			globalTileCount++;
//			Move 1 unit "upwards" based on this object's local rotation (e.g. with rotation 0,0,0 "upwards" is (0,1,0)... but with rotation 0,0,180 then "upwards" is (0,-1, 0)... )
			transform.position += transform.up;
			//transform.Translate(0f, 1f, 0f);
			//transform.position += transform.forward * Time.deltaTime * 1f;

//			Increment counter;
			FloorCounter++;


		//Destroy my game object; 
		} else {
			//Destroy(gameObject);
			
			//sort the floorEventNumber array
			System.Array.Sort(floorEventNumber);
			//show sorted floorEventNumbers in console		
			foreach( float number in floorEventNumber )
				{
				Debug.Log("sorted version:  " + number);
				}
			
			enabled = false; //disable code once the foreach code is finished
		}

	}
} 