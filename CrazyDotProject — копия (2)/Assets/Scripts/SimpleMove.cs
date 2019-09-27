using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimpleMove : MonoBehaviour {

    public float speed;
	void Start () {
            Destroy(gameObject, 5);
        

	}

    void Update()
    {
        transform.Translate(speed * Time.deltaTime, 0, 0 );
    }
}
