using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WC : MonoBehaviour {

    public Holder WCPanelHolder;

    public bool working;

    // Use this for initialization
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        ShieldChecker();
    }

    void ShieldChecker()
    {
        if (WCPanelHolder.isHolding)
        {
            working = true;
        }
        else
        {
            working = false;
        }
    }
}
