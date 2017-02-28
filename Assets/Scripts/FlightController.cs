using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlightController : MonoBehaviour {

    public float speed = 0.5f;
    public float horizontalRotationSpeed = 10f;
    public float verticalRotationSpeed = 10f;

	void Start () {
		
	}
	
	void Update () {
        transform.Translate(-transform.right * speed * Time.deltaTime, Space.World);
        HandleInput();
    }

    void HandleInput() {
        float vertical = Input.GetAxis("Horizontal") * horizontalRotationSpeed;
        float horizontal = Input.GetAxis("Vertical") * verticalRotationSpeed;
        transform.Rotate(vertical, 0, horizontal);
    }
}
