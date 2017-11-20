using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class baseScript : MonoBehaviour {

    public int health;

	// Use this for initialization
	void Start () {
        health = 100;
	}

    void decreaseHealth()
    {
        health = health = -10;
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
