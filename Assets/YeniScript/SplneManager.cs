using System.Collections;
using System.Collections.Generic;
using FluffyUnderware.Curvy;
using FluffyUnderware.Curvy.Controllers;
using UnityEngine;

public class SplneManager : MonoBehaviour
{
  public GameObject carPrefab;
  
  public int index=0;
  public List<CurvySpline> SplineList=new List<CurvySpline>();

  public void CarStarter()
  {
    // for (int i = 0; i < index; i++)
     //{
   // Debug.Log("SEY MAY NEYM", );
      var newSpawningCar = Instantiate(carPrefab,SplineList[0].FirstSegment.transform.position,Quaternion.identity);
      newSpawningCar.GetComponent<SplineController>().Spline = SplineList[0];//yolu göster
      newSpawningCar.GetComponent<SplineController>().Play();
      index++;
   // }  
  }
  
}
