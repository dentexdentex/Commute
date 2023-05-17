using System;
using System.Collections;
using System.Collections.Generic;
using FluffyUnderware.Curvy;
using FluffyUnderware.Curvy.Controllers;
using Unity.VisualScripting;
using UnityEngine;

public class Seyv : MonoBehaviour
{
    private SplneManager splineman;
    public SplineController _SplineController;
  
    public bool add=true;
    private void Start()
    {
       splineman=FindObjectOfType<SplneManager>();
       splineman.SplineList.Add(CurvySpline.Create());
       splineman.SplineList[splineman.index].Add(transform.position);
    }
    void Update()
    {
        if (add)
        {
            Debug.Log("index:" +splineman.index);
           // if (Vector3.Distance(transform.position,  splineman.SplineList[0].LastSegment.transform.position)>1.5f)
          {
              splineman.SplineList[splineman.index].Add(transform.position);
          }
        }
        if (Input.GetKey(KeyCode.A)){//splinr manager cagıracak
         _SplineController.Spline = splineman.SplineList[splineman.index];
         _SplineController.Play();
        }
    }
}
