using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;
/// <summary>
/// the script is used to turn the main music on and off
/// </summary>
public class MusicScript : MonoBehaviour {

    public Sprite mus_on, mus_off;
    GameObject obj;

    void Start()
    {
        obj = GameObject.Find("TheSavior");  
        if (gameObject.name == "Mus")
        {
            if (PlayerPrefs.GetString("Mus") == "off")
            {
                gameObject.GetComponent<Image>().sprite = mus_off;
                
                    obj.GetComponent<AudioSource>().enabled = false;

            }
        } 
    }

    public void MusicTwo()
    {
        if (PlayerPrefs.GetString("Mus") == "off")//play music now
        {
            GetComponent<Image>().sprite = mus_on;
            PlayerPrefs.SetString("Mus", "on");
            
               obj.GetComponent<AudioSource>().enabled = true;

        }
        else
        {
            GetComponent<Image>().sprite = mus_off;
            PlayerPrefs.SetString("Mus", "off");
            
          
                obj.GetComponent<AudioSource>().enabled = false;

        }
    }
}
