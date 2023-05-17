// using System.Collections;
// using System.Collections.Generic;
// using UnityEngine;
// public class FollowController : MonoBehaviour
// {
//     public Seyv characterController;
//     public GameObject followObject;
//     public float speed = 5f;
//     private int currentIndex = 0;
//
//     void Update()
//     {
//         // Karakterin hareket yolu tamamlanana kadar hareket ettiriyoruz.
//         if (currentIndex < characterController.pointsList.Count)
//         {
//             // Takip aracı, kaydedilen pozisyonlara doğru hareket eder.
//             followObject.transform.position = Vector3.MoveTowards(followObject.transform.position, characterController.pointsList[currentIndex], speed * Time.deltaTime);
//
//             // Takip aracı, hedef pozisyona ulaştığında bir sonraki hedef pozisyona geçer.
//             if (Vector3.Distance(followObject.transform.position, characterController.pointsList[currentIndex]) < 0.1f)
//             {
//                 currentIndex++;
//             }
//         }
//     }
// }
//
