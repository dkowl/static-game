using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveInZ : MonoBehaviour {

    private Vector3 startingPosition;

    void Start()
    {
        startingPosition = transform.position;
    }

    void Update()
    {
        transform.position = getNewVector();
    }

    Vector3 getNewVector()
    {
        return new Vector3(startingPosition.x, startingPosition.y, calculateNewYPosition());
    }

    float calculateNewYPosition()
    {
        return startingPosition.y + 5*(Time.time);
    }
}