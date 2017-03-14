using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour {

    public GameObject Spacecraft;
    public GameObject lookAt;

    public float damping;
    public float temp;

    private Vector3 offset;
    private FlightController flightController;

    void Start () {
        flightController = FindObjectOfType<FlightController>();
        offset = transform.position - Spacecraft.transform.position;
    }

	void LateUpdate () {
        Vector3 escalate = offset + offset * flightController.speed / temp;
        Vector3 desiredPosition = Spacecraft.transform.position + (Spacecraft.transform.rotation * escalate);
        transform.position = Vector3.Lerp(transform.position, desiredPosition, Time.deltaTime * damping);
        transform.LookAt(lookAt.transform, Spacecraft.transform.up);
    }
}
