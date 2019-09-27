using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
/// <summary>
/// when passing the eighth level goes to the stage with levels
/// </summary>
public class ColLVL8 : MonoBehaviour {

    public CameraController CameraController;

    void Start()
    {

    }


    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.tag == "Cross")
        {
            CameraController.enabled = false;

            SceneManager.LoadScene(10);
        }
    }
}
