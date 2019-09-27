using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DontDestrouMusic : MonoBehaviour {
    void Awake()
    {
        if (GameObject.FindGameObjectsWithTag("Audio").Length == 1)
        {
            DontDestroyOnLoad(transform.gameObject);

        }
        else
        {
            Destroy(gameObject);
        }
    }
}
