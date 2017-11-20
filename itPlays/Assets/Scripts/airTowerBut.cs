using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class airTowerBut : MonoBehaviour {

    bool activateAir;
    Text text;
    string og;
    // Use this for initialization
    void Start () {
        activateAir = false;
        text = GetComponentInChildren<Text>();
        og = text.text;
    }

    public void setAirFalse()
    {
        activateAir = false;
        text.text = og;
    }
    public void setAirTrue()
    {
        activateAir = true;
        text.text = "click to set location"; 
    }
    public bool GetAir()
    {
        return activateAir;
    }
}
