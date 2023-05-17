// using System;
// using System.Collections;
// using System.Collections.Generic;
// using UnityEngine;
//
// public class CarReplay : MonoBehaviour
// {
//     public Seyv _save;
//     private int currentPointIndex = 0;
//     private bool isDriving = false;
//     public List<Vector3> MyNewCarList;
//
//     public bool NewCarStart;
//
//     private void Start()
//     {
//         _save.GetComponent<Seyv>();
//     }
//
//
//     void Update()
//         {
//             if (Input.GetKeyDown(KeyCode.A))
//             {
//                 NewCarStart = true;
//             }
//
//             if (NewCarStart)
//             {
//                 Debug.Log("Yeni arac geliyo");
//                 // Aracın mevcut pozisyonunu, "pointsList" listesindeki bir sonraki noktaya doğru ilerletin.
//                 Vector3 targetPosition = _save.pointsList[currentPointIndex];
//                 transform.position = Vector3.MoveTowards(transform.position, targetPosition, Time.deltaTime * 10f);
//                 Debug.Log("transform :" + transform.position);
//                 // Aracın hedef noktaya doğru bakmasını sağlayın.
//                 transform.LookAt(targetPosition);
//
//                 // Eğer araç hedef noktaya ulaştıysa, bir sonraki noktaya doğru ilerleyin.
//                 if (transform.position == targetPosition)
//                 {
//                     currentPointIndex++;
//
//                     // Eğer araç "pointsList" listesindeki son noktaya ulaştıysa, sürüşü tamamladınız.
//                     if (currentPointIndex == _save.pointsList.Count)
//                     {
//                         isDriving = false;
//                         currentPointIndex = 0;
//                     }
//                 }
//             }
//         }
//     }
