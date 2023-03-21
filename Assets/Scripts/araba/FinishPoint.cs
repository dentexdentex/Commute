using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinishPoint : MonoBehaviour
{ 
   public bool  isDriveFinish;
   public CarController _carController;
   IEnumerator StopCar()
   {
       yield return new WaitForSeconds(0.5f); // 2 saniye bekle
       Time.timeScale = 0f; // oyunu duraklat
   }
  
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Car"))
        {
            isDriveFinish = true;
            
            Debug.Log("isdrivefinish:"+ isDriveFinish);
            StartCoroutine(StopCar()); // 2 saniye sonra oyunu duraklat
            
        }
    }
}