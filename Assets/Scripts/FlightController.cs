using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlightController : MonoBehaviour {

    public float speed = 0.5f;
    public float rotationSpeed = 30f;

	void Start () {
		
	}
	
	void Update () {
        transform.Translate(transform.forward * speed * Time.deltaTime, Space.World);
        HandleInput();
    }

    void HandleInput() {
        float horizontal = -Input.GetAxis("Horizontal") * rotationSpeed;
        float vertical = -Input.GetAxis("Vertical") * rotationSpeed;
        transform.Rotate(vertical, 0, horizontal);
    }
}
