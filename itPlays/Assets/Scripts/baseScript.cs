using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class baseScript : MonoBehaviour {

    public int health;
    public int coins;
    float lastUpdate;
    public Text hp;
    public Text cointcount;

    // Use this for initialization
    void Start () {
        health = 100;
        coins = 100;
	}

    public void decreaseHealth()
    {
        health = health-10;
    }
	
	// Update is called once per frame
	void Update () {

        //coins go up 10 at a time
        if (Time.time - lastUpdate >= 1f )
        {
            lastUpdate = Time.time;
            coins = coins + 10;
        }

        hp.text = "HP = " + health;
        cointcount.text = "Gold = " + coins;

    }
    public void minionKilled()
    {
        coins = coins + 1;
    }
    public void spawnTower()
    {
        coins = coins - 100;
    }


    void OnTriggerEnter2D(Collider2D other)
    {
        decreaseHealth();

        Destroy(other.gameObject);
    }
}
