﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mouseControl : MonoBehaviour {

    Vector2 mouseLook;
    Vector2 smoothV;
    public float sensitivity = 5f;
    public float smoothing = 2f;

    GameObject charackter;

	// Use this for initialization
	void Start () {
		charackter = this.transform.parent.gameObject;
	}
	
	// Update is called once per frame
	void Update () {
        var md = new Vector2(Input.GetAxisRaw("Mouse X"), Input.GetAxisRaw("Mouse Y"));

        md = Vector2.Scale(md, new Vector2(sensitivity * smoothing, sensitivity * smoothing));
        smoothV.x = Mathf.Lerp(smoothV.x, md.x, 1f / smoothing);
        smoothV.y = Mathf.Lerp(smoothV.y, md.y, 1f / smoothing);
        mouseLook += smoothV;
        transform.localRotation = Quaternion.AngleAxis(-mouseLook.y, Vector3.right);
        charackter.transform.localRotation = Quaternion.AngleAxis(mouseLook.x, charackter.transform.up);
    }
}
