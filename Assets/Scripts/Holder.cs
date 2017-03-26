using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Holder : MonoBehaviour
{

    public int ID;
    public bool isHolding;

    Grabable[] grabables;
    // Use this for initialization
    void Start()
    {
        grabables = FindObjectsOfType<Grabable>();
        isHolding = true;
    }

    // Update is called once per frame
    void Update()
    {
        foreach (Grabable grababale in grabables)
        {
            if (ID == grababale.ID)
            {
                if (transform.position == grababale.transform.position)
                {
                    isHolding = true;
                }
                else
                {
                    isHolding = false;
                }
            }
        }
    }
}
