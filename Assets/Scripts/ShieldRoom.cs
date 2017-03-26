using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShieldRoom : MonoBehaviour {

    public Holder ShieldWall1Holder;
    public Holder ShieldWall2Holder;
    public Holder CrystalHolder;
    public Destroyed Crystal;
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
        if (ShieldWall1Holder.isHolding && ShieldWall2Holder.isHolding && CrystalHolder.isHolding && !Crystal.isDestroyed)
        {
            working = true;
        }
        else
        {
            working = false;
        }
    }
}