using System.Collections;
using System.Collections.Generic;
using UnityEngine.Advertisements;
using UnityEngine;

public class KillPlayer : MonoBehaviour {
    public GameObject obj;
    private static int advCount = 0;
	void Start () {
        //this is for ads from unity ads
        if (Advertisement.isSupported)
        {
            Advertisement.Initialize("2831309", false);
        }
        
    }
	


		void OnCollisionEnter2D(Collision2D col)
        {
            if(col.gameObject.tag == "Cross")
            {
                Destroy(obj);
            //and this
            advCount++;
            if (Advertisement.IsReady() && advCount %5 == 0){
                Advertisement.Show();
            }
            }

        }
	
}
