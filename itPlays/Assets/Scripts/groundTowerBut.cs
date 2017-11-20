using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class groundTowerBut : MonoBehaviour {
    bool activateGround;
    Text text;
    string og;
    // Use this for initialization
    void Start()
    {
        activateGround = false;
        text = GetComponentInChildren<Text>();
        og = text.text;
    }

    public void setGroundFalse()
    {
        activateGround = false;
        text.text = og;
    }
    public void setGroundTrue()
    {

        activateGround = true;
        text.text = "click to set location";

    }
    public bool GetGround()
    {
        return activateGround;
    }
}
