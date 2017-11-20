using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class baseScript : MonoBehaviour {

    public int health;
    public Text hp;

	// Use this for initialization
	void Start () {
        health = 100;
	}

    public void decreaseHealth()
    {
        health = health-10;
    }
	
	// Update is called once per frame
	void Update () {

        hp.text = "HP = " + health;
		
	}
}
