using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SphereScript : MonoBehaviour {

    private Vector3 startingPosition;

	void Start () {
        startingPosition = transform.position;
	}
	
	void Update () {
        transform.position = getNewVector();
	}

    Vector3 getNewVector() {
        return new Vector3(startingPosition.x, calculateNewYPosition(), startingPosition.z);
    }

    float calculateNewYPosition() {
        return startingPosition.y + Mathf.Sin(Time.time);
    }
}
