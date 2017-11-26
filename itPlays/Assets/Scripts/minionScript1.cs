using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class minionScript1 : MonoBehaviour {

    public bool playerControl = true;
    public float speed = 0.5f;
    int steps;
    int yDir;
    int xDir;
    Vector3 dir;
    // Use this for initialization
    void Start () {
        
        steps = Random.Range(10, 20);
        yDir = Random.Range(-1, 2);
        xDir = Random.Range(-1, 2);
        dir = new Vector3(xDir, yDir, 0);
    }
	
	// Update is called once per frame
	void FixedUpdate () {
        if (playerControl)
        {
            this.transform.position += speed * (new Vector3(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"), 0));
        }
        else
        {
            //inbound = 0,0  to 60,60

            if (steps > 0)
            {
                this.transform.position += speed*.5f * (dir);

                steps -= 1;
            }
            else
            {
                steps = Random.Range(10, 20);
                yDir = Random.Range(-1, 2);
                xDir = Random.Range(-1, 2);
                dir = new Vector3(xDir, yDir, 0);

            }

            if (this.transform.position.x < 0 || this.transform.position.x > 60)
                dir.x = dir.x * -1;
            if (this.transform.position.y < 0 || this.transform.position.y > 60)
                dir.y = dir.y * -1;
        }
    }
}
