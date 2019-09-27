using System.Linq;
using System.Collections.Generic;
using UnityEngine;

public class DrawLine : MonoBehaviour {

    public LineRenderer LineRenderer;//responsible for the schedule
    public EdgeCollider2D EdgeCol;//responsible for the line physics

    //the line will be created using points and for this you need to create either an array or a list

    List<Vector2> points;//list is needed to save points
    public void UpdateLine(Vector2 mousePos)
    {
        if(points == null)//if no points are created
        {
            points = new List<Vector2>();
            SetPoint(mousePos);
            return;
        }
        //check the distance between the previously inserted point and the current point
        if (Vector2.Distance(points.Last(), mousePos) > .1f)
            SetPoint(mousePos);
    }


    void SetPoint(Vector2 point)//insert with dot
    {
        points.Add(point);//we must get a point array to add a new point
        LineRenderer.positionCount = points.Count;//Set the number of positions equal count count
        LineRenderer.SetPosition(points.Count - 1, point);//this way we get the last index in the list
        if (points.Count > 1)

        EdgeCol.points = points.ToArray();
    }
}
