using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gtScript : MonoBehaviour {

    public int chasing = 0;
    public Transform child;
    public Transform enemy;
    public int fire = 3;
	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void FixedUpdate () {
        if (chasing==0) {
            child.Rotate(new Vector3(0, 0, -1));
        }
        else
        {
            Vector3 difference = enemy.position - transform.position;
            float rotationZ = Mathf.Atan2(difference.y, difference.x) * Mathf.Rad2Deg;
            child.rotation = Quaternion.Euler(0.0f, 0.0f, rotationZ-90);
        }https://answers.unity.com/questions/1023987/lookat-only-on-z-axis.html#

        if (fire == 0)
        {

        }
        else
        {

        }

	}
    void OnTriggerEnter2D(Collider2D coll)
    {
        enemy = coll.gameObject.transform;
        chasing++;
    }
    void OnTriggerExit2D(Collider2D coll)
    {
        print("2");
        chasing--;
    }
}
