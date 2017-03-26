using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NavSwitch : MonoBehaviour {

    PilotDisp pilotDisp;
    Image warning;
    Color color;
    // Use this for initialization
    void Start () {
        pilotDisp = FindObjectOfType<PilotDisp>();
        warning = GetComponent<Image>();
        color = warning.color;
        color.a = 0f;
        warning.color = color;
    }
	
	// Update is called once per frame
	void Update () {
        if (pilotDisp.needReboot && warning.color.a < 1f)
        {
            color.a = 0.1f;
            warning.color = warning.color + color;
        }
        else if(!pilotDisp.needReboot && warning.color.a > 0f) {
            color.a = 0.1f;
            warning.color = warning.color - color;
        }
	}
}
