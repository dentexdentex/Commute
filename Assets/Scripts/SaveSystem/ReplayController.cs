using System;
using UnityEngine;

public class ReplayController : MonoBehaviour
{
    public FinishPoint _finishPoint;
    public Seyv characterController;
    public GameObject replayObject;
    private bool replayStarted = false;

   

    void Update()
    {
        if (_finishPoint.isDriveFinish)
        {
            Debug.Log("a");
            // Replay'i başlatıyoruz.
            replayStarted = true;
            characterController.DrawLine();
            _finishPoint.isDriveFinish = false;
        }

        if (replayStarted)
        {
            // Replay'in sona erip ermediğini kontrol ediyoruz.
            if (characterController.lineRenderer.positionCount == characterController.pointsList.Count)
            {
                replayStarted = false;
                Debug.Log("replayStarted =" +replayStarted);
            }
            else
            {
                Debug.Log("ELSE ");
                // Replay'i gerçekleştiriyoruz.
                int index = characterController.lineRenderer.positionCount;
                replayObject.transform.position = characterController.lineRenderer.GetPosition(index - 1);
                characterController.lineRenderer.positionCount--;
            }
        }
    }
}