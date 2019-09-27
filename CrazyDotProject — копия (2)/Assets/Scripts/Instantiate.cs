using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// script uses in the eighth level to create obstacles
/// </summary>
public class Instantiate : MonoBehaviour {
    public GameObject obj;
    public float spaunTime;

    void Start()
    {
        InvokeRepeating("SpaunBlock", 0, spaunTime);
        
    }

    void SpaunBlock()
    {
        GameObject block = Instantiate(obj, transform.position, transform.rotation) as GameObject;
    }
    
}
