using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlightController : MonoBehaviour {

    public float speed = 50f;
    public float maxSpeed = 500f;
    public float acceleration = 40f;
    public float decceleration = 160f;
    public float horizontalRotationSpeed = 10f;
    public float verticalRotationSpeed = 10f;
    public float turningSpeed = 5f;

    public bool isPiloted = false;

    private float speedChange;

    void Update () {
        HandleSpeedInput();
        if (isPiloted)
        {
            HandleTurningInput();
        }
        else
        {
            speedChange = decceleration * Time.deltaTime;
            if (speed < speedChange)
            {
                speedChange = speed;
            }
            speed -= speedChange;
        }
    }

    void HandleTurningInput() {
        float vertical = Input.GetAxis("Horizontal") * horizontalRotationSpeed;
        float horizontal = Input.GetAxis("Vertical") * verticalRotationSpeed;
        float turning = Input.GetAxis("Turning") * turningSpeed;
        transform.Rotate(vertical, turning, horizontal);
    }

    void HandleSpeedInput() {
        HandleAcceleration();
        HandleBraking();
        HandleSpeedChange();
    }
    
    void HandleAcceleration() {
        speedChange = acceleration * Time.deltaTime;
        if (Input.GetKey(KeyCode.Space) && speed <= maxSpeed && isPiloted) {
            float diff = maxSpeed - speed;
            if (diff < acceleration) {
                speedChange = diff;
            }
            speed += speedChange;
        }
    }

    void HandleBraking() {
        speedChange = decceleration * Time.deltaTime;
        if (Input.GetKey(KeyCode.LeftShift) && speed >= 0) {
            if (speed < speedChange) {
                speedChange = speed;
            }
            speed -= speedChange;
        }
    }

    void HandleSpeedChange() {
        transform.Translate(-transform.right * speed * Time.deltaTime, Space.World);
    }
}
