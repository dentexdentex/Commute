using System.Collections.Generic;
using System.IO;
using UnityEngine;

public class SaveSystem : MonoBehaviour
{
    public LineRenderer lineRenderer;
    public int maxPositions = 1000;
    public float lineWidth = 0.5f;
    public Color lineColor = Color.white;
    private Vector3[] positions = new Vector3[0];
    private List<Vector3> passedPositions = new List<Vector3>();

    private LineRenderer _nextCarLineRenderer;
    

    private void Start()
    {
        lineRenderer.startWidth = lineWidth;
        lineRenderer.endWidth = lineWidth;
        lineRenderer.startColor = lineColor;
        lineRenderer.endColor = lineColor;
    }
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))//bunu trigger olduugnda calıstır
        {
            // Triger oldugunda yeni line redenrere tutucaz.
            _nextCarLineRenderer = lineRenderer;
            PlayerPrefs.GetInt("position", 0); // Bunu bir sonraki arabanın takip etmesi gereken position listesinin position sayısı loadlamak için.
            PlayerPrefs.SetInt("position",lineRenderer.positionCount); // Bu da araba ulaştıgında izlediği yolun position listesinin countunu savelemek için.

            for (int i = 0; i < _nextCarLineRenderer.positionCount; i++)
            {
                passedPositions.Add(_nextCarLineRenderer.GetPosition(i));
            }
            
            // passedPOsition'sı yeni arabanın izleyecegi yol bu olucak
        }
    }
    private void SavePositions()
    {
        string path = Application.dataPath + "/positions.txt";
        using (StreamWriter writer = new StreamWriter(path))
        {
            foreach (Vector3 position in positions)
            {
                writer.WriteLine(position.x + "," + position.y + "," + position.z);
            }
        }
    }

    private void LoadPositions()
    {
        string path = Application.dataPath + "/positions.txt";
        if (File.Exists(path))
        {
            List<Vector3> positionsList = new List<Vector3>();
            using (StreamReader reader = new StreamReader(path))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    string[] positionValues = line.Split(',');
                    float x = float.Parse(positionValues[0]);
                    float y = float.Parse(positionValues[1]);
                    float z = float.Parse(positionValues[2]);
                    Vector3 position = new Vector3(x, y, z);
                    positionsList.Add(position);
                }
            }
            positions = positionsList.ToArray();
            lineRenderer.positionCount = positions.Length;
            lineRenderer.SetPositions(positions);
        }
    }
}