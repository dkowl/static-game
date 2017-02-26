using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlightController : MonoBehaviour {

    public float speed = 0.5f;
    public float rotationSpeed = 10f;

	void Start () {
		
	}
	
	void Update () {
        transform.Translate(transform.forward * speed * Time.deltaTime, Space.World);
        HandleInput();
    }

    void HandleInput() {
        if (Input.GetKey(KeyCode.A)) {
            transform.Rotate(0, 0, rotationSpeed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.D)) {
            transform.Rotate(0, 0, -rotationSpeed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.W)) {
            transform.Rotate(-rotationSpeed * Time.deltaTime, 0, 0);
        }
        if (Input.GetKey(KeyCode.S)) {
            transform.Rotate(rotationSpeed * Time.deltaTime, 0, 0);
        }
    }
}
