using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class FinishPoint : MonoBehaviour
{ 
    private SplneManager _SplneManager;
  // public CarController _carController;
   private void Start()
   {
       FindObjectOfType<SplneManager>();
   }
   IEnumerator StopCar()
   {
       yield return new WaitForSeconds(0.5f); // 2 saniye bekle
       //Time.timeScale = 0f; // oyunu duraklat
   }
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Car"))
        {
            Debug.Log("isdrivefinish:");
            StartCoroutine(StopCar());
          //  other.gameObject.SetActive(false);
            _SplneManager.CarStarter();
        }
    }
}