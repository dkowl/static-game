using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Grabable : MonoBehaviour {

    public bool isGrabbed = false;
    public Camera playerCam;
    private Rigidbody rigidbody;
    Vector3 offset;
    Renderer renderer;
    Color color;
    

    // Use this for initialization
    void Start () {
        rigidbody = GetComponent<Rigidbody>();
        renderer = GetComponent<Renderer>();
        color = renderer.material.color;
    }
	
	// Update is called once per frame
	void Update () {
        if (isGrabbed) {
            color.a = 0.3f;
            renderer.material.color = color;
            offset = playerCam.transform.position + playerCam.transform.forward * 1.5f - transform.position;
            rigidbody.velocity = offset*8f;
        }
    }

    public void ShootHeldObject() {
        rigidbody.velocity = playerCam.transform.forward * 15f;
        color.a = 1f;
        renderer.material.color = color;

    }

    public void LetHeldObjectGoLezkaSieWOkuKreci() {
        color.a = 1f;
        renderer.material.color = color;
    }
}
