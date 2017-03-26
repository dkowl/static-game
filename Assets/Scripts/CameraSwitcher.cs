using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraSwitcher : MonoBehaviour {

    public Camera shipCam;
    public Camera playerCam;
    private FlightController SpaceCraft;
 
    void Start()
    {
        playerCam.enabled = true;
        shipCam.enabled = false;
        SpaceCraft = FindObjectOfType<FlightController>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.C))
        {
            playerCam.enabled = !playerCam.enabled;
            shipCam.enabled = !shipCam.enabled;
        }
        if (shipCam.enabled && !SpaceCraft.isPiloted) {
            shipCam.enabled = false;
            playerCam.enabled = true;
        }
    }
}
