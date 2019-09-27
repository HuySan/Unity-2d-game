using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// used to ignore a line by a physical object
/// </summary>
public class NONCOL : MonoBehaviour {
    public GameObject EdjeCol;
    public GameObject Xcol;

    void Start () {
		
	}
	
        
    void Update()
    {
        Physics2D.IgnoreLayerCollision(8,9);
    }

}
