using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePlatform : MonoBehaviour {
    public float speed = 7f;
    public float speed2 = 7f;

    void Start () {
		
	}
	
	void Update () {
        transform.Translate(speed * Time.deltaTime, 0, 0);
        if(transform.position.x > -2.6)
        {
            speed = -speed;
        }
        if(transform.position.x < -7.30)
        {
            speed = speed2;
        }
	}
}
