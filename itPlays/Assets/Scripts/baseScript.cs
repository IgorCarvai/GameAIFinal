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
    public GameObject GT;
    public GameObject AT;
    List<GameObject> groundTowers;
    List<GameObject> airTowers;
    List<GameObject> groundMinions;
    List<GameObject> airMinions;

    List<Vector2> posibleTowers;


    // Use this for initialization
    void Start () {
        groundTowers = new List<GameObject>();
        airTowers = new List<GameObject>();
        groundMinions = new List<GameObject>();
        airMinions = new List<GameObject>();
        health = 100;
        coins = 100;
        findGTsATs();
        posibleTowers = new List<Vector2>();
        for(int i =6; i<=54; i = i + 12)
        {
            for (int j = 6; j <= 54; j = j + 12)
            {
                if (i == 6 && j == 54)
                    continue;
                posibleTowers.Add(new Vector2(i, j));
            }

        }
        foreach(Vector2 loc in posibleTowers)
        {
            Instantiate(GT, new Vector3(loc.x, loc.y, -2), Quaternion.identity);
        }
    }
    // Update is called once per frame
    void Update()
    {

        findGTsATs();
        findGMsAMs();
        UpdateMinions();
        UpdateGui();

        Vector2 spot = furthestSpot();

    }
    Vector2 furthestSpot()
    {
        return new Vector2(1f, 1f);
    }
    //since minions can be destroyed, we need to remove the ones that are null
    void UpdateMinions()
    {
        for (int i = 0; i < airMinions.Count;)
        {
            if(airMinions[i] == null)
            {
                airMinions.RemoveAt(i);
                i = i - 1;
            }
            else
            {
                i++;
            }
        }
        for (int i = 0; i < groundMinions.Count;)
        {
            if (airMinions[i] == null)
            {
                groundMinions.RemoveAt(i);
                i = i - 1;
            }
            else
            {
                i++;
            }
        }

    }

    //goes through all the objects in the game and finds the Ground and Air towers and appends them to the appropriate lists
    void findGTsATs()
    {
        foreach(GameObject tower in GameObject.FindGameObjectsWithTag("GT"))
        {
            if (!groundTowers.Contains(tower))
            {
                groundTowers.Add(tower);
            }

        }
        foreach (GameObject tower in GameObject.FindGameObjectsWithTag("AT"))
        {
            if (!airTowers.Contains(tower))
            {
                airTowers.Add(tower);
            }
        }
    }


    //goes through all the objects in the game and finds the Ground and Air minions and appends them to the appropriate lists
    void findGMsAMs()
    {
        foreach (GameObject minion in GameObject.FindGameObjectsWithTag("GM"))
        {
            if (!groundMinions.Contains(minion))
            {
                groundMinions.Add(minion);
            }

        }
        foreach (GameObject minion in GameObject.FindGameObjectsWithTag("AM"))
        {
            if (!airMinions.Contains(minion))
            {
                airMinions.Add(minion);
            }
        }
    }


    public void decreaseHealth()
    {
        health = health-10;
    }
	
    void UpdateGui()
    {    //coins go up 10 at a time
        if (Time.time - lastUpdate >= 1f)
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
