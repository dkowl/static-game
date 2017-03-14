using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour {

    public GameObject Spacecraft;
    public float damping;

    private float factor = 0.04f;
    private Vector3 offset;
    private FlightController flightController;

    void Start () {
        flightController = FindObjectOfType<FlightController>();
        offset = transform.position - Spacecraft.transform.position;
    }

	void LateUpdate () {
        Vector3 escalation = offset + new Vector3(flightController.speed*factor, flightController.speed * factor*0.8f, 0);
        Vector3 desiredPosition = Spacecraft.transform.position + (Spacecraft.transform.rotation * escalation);
        transform.position = Vector3.Lerp(transform.position, desiredPosition, Time.deltaTime * damping);
        transform.LookAt(Spacecraft.transform, Spacecraft.transform.up);
    }
}
