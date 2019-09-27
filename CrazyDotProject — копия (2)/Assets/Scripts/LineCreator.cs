using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LineCreator : MonoBehaviour {
    public GameObject LinePrefab;
    DrawLine  activeLine;
    //---------------------------------------------------------------------------------------------------------------------------------------
    //In general, this variable activates the script "LineCreator"
    //---------------------------------------------------------------------------------------------------------------------------------------

    //way to get input from the player
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            GameObject LineGo = Instantiate(LinePrefab);//use this game object to get the line script
            activeLine = LineGo.GetComponent<DrawLine>();
        }

        if (Input.GetMouseButtonUp(0))
        {
            activeLine = null;
        }

        if(activeLine != null)
        {
            Vector2 mousPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            activeLine.UpdateLine(mousPos);
        }
    }

}
