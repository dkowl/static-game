using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Grabable : MonoBehaviour {

    public int ID;

    public bool isGrabbed = false;
    public Camera playerCam;
    public Transform holder;
    
    private Rigidbody rigidbody;
    Telekenisis telekenisis;
    Vector3 offset;
    Renderer renderer;
    Color color;
    Quaternion startingOrientation; // = gay
    

    // Use this for initialization
    void Start () {
        rigidbody = GetComponent<Rigidbody>();
        renderer = GetComponent<Renderer>();
        color = renderer.material.color;
        startingOrientation = transform.rotation;
        telekenisis = FindObjectOfType<Telekenisis>();
        rigidbody.isKinematic = true;
    }
	
	// Update is called once per frame
	void Update () {
        if (isGrabbed)
        {
            color.a = 0.3f;
            renderer.material.color = color;
            offset = playerCam.transform.position + playerCam.transform.forward * 1.5f - transform.position;
            rigidbody.velocity = offset * 8f;

            if (telekenisis.pullID == ID)
            {
                color.r = 0.3f;
                color.b = 0.3f;
                renderer.material.color = color;
            }
            else
            {
                color.r = 1f;
                color.b = 1f;
                renderer.material.color = color;
            }

            if (telekenisis.pullID == ID && Input.GetKeyDown(KeyCode.Mouse0))
            {
                Invoke("ChangeLayer", 0.05f);
                isGrabbed = false;
                offset = holder.transform.position - transform.position;
                rigidbody.isKinematic = true;
                rigidbody.MovePosition(offset + transform.position);
                rigidbody.MoveRotation(startingOrientation);
                color.a = 1f;
                renderer.material.color = color;
                
            }
            else if (Input.GetKeyDown(KeyCode.Mouse0))
            {
                Invoke("ChangeLayer", 0.05f);
                isGrabbed = false;
                ShootHeldObject();
            }
            else if (Input.GetKeyDown(KeyCode.Mouse1))
            {
                ChangeLayer();
                isGrabbed = false;
                LetHeldObjectGoLezkaSieWOkuKreci();
            }
        }
        else
        {
            color.r = 1;
            color.b = 1;
            renderer.material.color = color;
        }
        
    }

    public void ShootHeldObject() {
        rigidbody.velocity = playerCam.transform.forward * 15f;
        color.a = 1f;
        renderer.material.color = color;

    }
    void ChangeLayer() {
        gameObject.layer = 8;
        telekenisis.isHolding = false;
    }
    

    public void LetHeldObjectGoLezkaSieWOkuKreci() {
        color.a = 1f;
        renderer.material.color = color;
    }
}
