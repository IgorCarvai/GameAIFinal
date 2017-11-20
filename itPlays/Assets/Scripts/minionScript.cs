using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class minionScript : MonoBehaviour
{
    float counter = 0;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        counter = counter + Time.deltaTime;
        if (counter >.5) { 
            this.transform.position = new Vector3(this.transform.position.x - .5f, this.transform.position.y + .5f, -3);
            counter = 0;
        }
    }
    void OnCollisionEnter2D(Collision2D coll)
    {
        Destroy(this);
    }
}
