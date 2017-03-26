using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EngineRoom : MonoBehaviour {

    public Holder EngineSiadeWall1Holder;
    public Holder EngineSiadeWall2Holder;
    public Holder EngineWallHolder;
    public Holder FanLHolder;
    public Holder FanRHolder;
    public Holder EngineDoorHolder;
    public Holder PowerCoreHolder;
    public Destroyed PowerCore;
    public bool working;

    // Use this for initialization
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        EngineCheck();
    }
    void EngineCheck() {
        if (EngineSiadeWall1Holder.isHolding && EngineSiadeWall2Holder.isHolding && EngineWallHolder.isHolding
            && FanLHolder.isHolding && FanRHolder.isHolding && EngineDoorHolder.isHolding && PowerCoreHolder.isHolding
            && !PowerCore.isDestroyed)
        {
            working = true;
        }
        else {
            working = false;
        }
    }
}
