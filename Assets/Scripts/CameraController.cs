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

	void LateUpdate () {
        Vector3 desiredPosition = target.transform.position + (target.transform.rotation * offset);
        transform.position = Vector3.Lerp(transform.position, desiredPosition, Time.deltaTime * damp);
        transform.LookAt(target.transform, target.transform.up);
    }
}
