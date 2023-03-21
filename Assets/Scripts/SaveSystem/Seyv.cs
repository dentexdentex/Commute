using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Seyv : MonoBehaviour
{
    public LineRenderer lineRenderer;
    public List<Vector3> pointsList = new List<Vector3>();
 
    void Update()
    {
        pointsList.Add(transform.position);//Karakter pozisyonları kaydet
    }
 
    public void DrawLine()
    {
        lineRenderer.positionCount = pointsList.Count; //line renderera ekle
        lineRenderer.SetPositions(pointsList.ToArray());
    }
}
