using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// I forgot why this script is needed, I think it is not in vain here
/// </summary>
public class PlayerAttach : MonoBehaviour {

    public GameObject obj;
    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag == "Cross")
        {
            col.transform.parent = col.transform;
        }
    }
    void OnCollisionExit2D(Collision2D col)
    {
        if(col.gameObject.tag == "Cross")
        {
            col.transform.parent = null;
        }
    }
}
