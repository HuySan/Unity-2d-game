using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KillPlayerInst : MonoBehaviour {

	void OnCollisionEnter2D(Collision2D col) {
        if (col.gameObject.name == "Player")
        {
            Destroy(col.gameObject);
        }
    }
}
