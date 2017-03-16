using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraSwitcher : MonoBehaviour {

    public Camera shipCam;
    public Camera playerCam;
 
    void Start()
    {
        playerCam.enabled = true;
        shipCam.enabled = false;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.C))
        {
            playerCam.enabled = !playerCam.enabled;
            shipCam.enabled = !shipCam.enabled;
        }
    }
}
