using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Telekenisis : MonoBehaviour
{
    public bool isHolding = false;
    public int pullID;

    void Start()
    {
    }

     void Update()
    {
        Vector3 fwd = transform.TransformDirection(Vector3.forward);

        int layerMask = 1 << 12;
        layerMask = ~layerMask;

        RaycastHit hit;
        Physics.SphereCast(transform.position, 0.2f, fwd, out hit, 20f, layerMask);
        Grabable grabable = hit.collider.GetComponent<Grabable>();
        Rigidbody rigidbody = hit.collider.GetComponent<Rigidbody>();
        Holder holder = hit.collider.GetComponent<Holder>();
        if (holder)
        {
            pullID = holder.ID;
        }
        else {
            pullID = -1;
        }

        if (Input.GetKeyDown(KeyCode.Mouse0) && grabable.isGrabbed == false && grabable && !isHolding)
        {
            rigidbody.isKinematic = false;
            grabable.isGrabbed = true;
            isHolding = true;
            grabable.gameObject.layer = 12;
        }
    }

}
    

 
