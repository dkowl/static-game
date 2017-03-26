using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerCoreCheck : MonoBehaviour {

    public Holder PowerCoreHolder;
    private MeshCollider meshCollider;
    public Destroyed PowerCore;

	// Use this for initialization
	void Start () {
       meshCollider = GetComponent<MeshCollider>();
	}
	
	// Update is called once per frame
	void Update () {
        if (PowerCoreHolder.isHolding && !PowerCore.isDestroyed) {
            meshCollider.enabled = true;
        }
        else if (!PowerCoreHolder.isHolding || PowerCore.isDestroyed) {
            meshCollider.enabled = false;
            }
        }
	}

