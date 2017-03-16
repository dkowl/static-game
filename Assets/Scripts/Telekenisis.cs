using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Telekenisis : MonoBehaviour
{

    void Start()
    {
    }

    void Update()
    {
        Vector3 fwd = transform.TransformDirection(Vector3.forward);

        RaycastHit hit;
        if (Physics.Raycast(transform.position, fwd, out hit, 10)) {
            Grabable grabable = hit.collider.GetComponent<Grabable>();
            if (grabable)
            {
                if (Input.GetKeyDown(KeyCode.Mouse0) && grabable.isGrabbed == false)
                {
                    grabable.isGrabbed = true;
                }
                else if (Input.GetKeyDown(KeyCode.Mouse0) && grabable.isGrabbed == true)
                {
                    grabable.isGrabbed = false;
                    grabable.ShootHeldObject();

                }
                else if (Input.GetKeyDown(KeyCode.Mouse1) && grabable.isGrabbed == true) {
                    grabable.isGrabbed = false;
                    grabable.LetHeldObjectGoLezkaSieWOkuKreci();
                }

            }
        }
    }
}
 
