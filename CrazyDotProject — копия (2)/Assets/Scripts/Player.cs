using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
/// <summary>
/// when you click on "tap to start"
/// </summary>
public class Player : MonoBehaviour {
    public Rigidbody2D rb;
    public   GameObject ContinueMenu;


    
    public void Continue()
    {

        ContinueMenu.SetActive(false);
        rb.bodyType = RigidbodyType2D.Dynamic;
    }

		

}
