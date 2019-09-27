using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;
/// <summary>
/// script is used to navigate between levels and their preservation
/// </summary>

public class OFFscript : MonoBehaviour
{

    public CameraController CameraController;

    void Start()
    {

    }


    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.tag == "Cross")
        {
            CameraController.enabled = false;

            if (SceneManager.GetActiveScene().buildIndex == LevelManager.countUnlockedLevel)
            {
                LevelManager.countUnlockedLevel++;
                PlayerPrefs.SetInt("Levels", LevelManager.countUnlockedLevel);
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
            }
            else
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
            }
        }
    }
}
