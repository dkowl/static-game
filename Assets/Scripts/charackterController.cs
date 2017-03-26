using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class charackterController : MonoBehaviour {

    public float Walkspeed = 10f;
    public float StrafeSpeed = 8f;
   // Rigidbody rigidbody;
    //RaycastHit hit;
    public GameObject SpaceCraft;
    

	// Use this for initialization
	void Start () {
        Cursor.lockState = CursorLockMode.Locked;
       // rigidbody = GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void Update () {

       

        float translation = Input.GetAxis("Vertical") * Walkspeed * Time.deltaTime;
        float strafe = Input.GetAxis("Horizontal") * StrafeSpeed * Time.deltaTime;



        transform.rotation = SpaceCraft.transform.rotation;
        Debug.Log(transform.rotation);
        Debug.Log(SpaceCraft.transform.rotation);

        transform.Translate(strafe, 0, translation);

        if (Input.GetKeyDown("escape")) {
            Cursor.lockState = CursorLockMode.None;
        }
	}

   void FixedUpdate() {

        //rigidbody.velocity = -transform.up;

        RaycastHit hitInfo;
        Physics.Raycast(transform.position, -transform.up, out hitInfo);

       // rigidbody.velocity = -hitInfo.normal*2;

        //Debug.Log(hitInfo.point);
        // Vector3 offset = transform.position - hitInfo.point;
        //transform.position = new Vector3(transform.position.x, offset.y + hitInfo.point.y, transform.position.z);
        //transform.position = new Vector3(transform.position.x, hitInfo.point.y + 1.1f, transform.position.z);
        // transform.position. = 
    }
}
