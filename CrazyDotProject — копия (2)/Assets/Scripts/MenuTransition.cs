using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;

public class MenuTransition : MonoBehaviour {


    public void MainMenu ()
    {
        SceneManager.LoadScene(9);
    }
    public void Levels()
    {
        SceneManager.LoadScene(10);
    }
    public void QuitGame ()
    {
        Debug.Log("QuitGame");
        Application.Quit();
    }
     }
