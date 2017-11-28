using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bulletScript : MonoBehaviour {

    public Vector3 dir;
    public int life=3;
    public float lastUpdate = 0;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        this.transform.position += dir;
        if (Time.time - lastUpdate >= 1f)
        {
            life -= 1;
            lastUpdate = Time.time;
        }

        if (life <= 0 || this.transform.position.x<0 || this.transform.position.x>60|| this.transform.position.y<0|| this.transform.position.y>60)
        {
            Destroy(this.gameObject);
        }

    }
    void OnTriggerEnter2D(Collider2D coll)
    {
        if (coll.gameObject.tag == "Minion")
        {
            Destroy(coll.gameObject);
            Destroy(this.gameObject);
        }
    }
}
