using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour {

    public GameObject target;
    public float damp;

    private Vector3 offset;

	void Start () {
        offset = transform.position - target.transform.position;
        
    }
    Quaternion rot1 = Quaternion.identity;
	void LateUpdate () {
        Quaternion rot2 = target.transform.rotation;
        Quaternion rotation = Quaternion.Lerp(rot1, rot2, damp);
        rot1 = rot2;
        transform.position = target.transform.position + (rotation * offset);
        //transform.position = target.transform.position + (target.transform.rotation * offset);

        transform.LookAt(target.transform, target.transform.up);
        //Quaternion rot = target.transform.rotation;
        //Debug.Log(target.transform.rotation.x);
        //transform.Rotate(0, 0, -Input.GetAxis("Horizontal") * target.GetComponent<FlightController>().horizontalRotationSpeed);
        //transform.Rotate(target.transform.eulerAngles.x, 0, 0, Space.World);
    }
}
