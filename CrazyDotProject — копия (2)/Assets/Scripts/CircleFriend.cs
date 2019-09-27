using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// determines the operation of the platform in the eighth level
/// </summary>
public class CircleFriend : MonoBehaviour {

    public float speed = 2f;
    public GameObject obj;
    public GameObject obj2;
    int moved ;
    void Update()
    {
        if(moved == 1)
        {
            obj.transform.Translate(Time.deltaTime * speed, 0, 0);
            Destroy(obj, 5);
            Destroy(obj2.gameObject);
        }
    }

    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.name == "Cir")
        {
            moved = 1;
        }
    }

}
