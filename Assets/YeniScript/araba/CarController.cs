using UnityEngine;

public class CarController : MonoBehaviour
{
  //  public FinishPoint _finishPoint;
    public float speed = 10f; 
    public float rotationSpeed = 100f; //dönüş hızı
    public Transform startPoint; 
    //public Transform finishPoint; //silinebilir
    public GameObject myObject;

    void Start()
    {
        myObject = GameObject.Find("MainCar"); // GameObject nesnesini bulun
        transform.position = startPoint.position; 
        transform.rotation = startPoint.rotation; 
    }
    void FixedUpdate()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.forward * speed * Time.deltaTime); 
        transform.Rotate(Vector3.up, horizontalInput * rotationSpeed * Time.deltaTime); 
    }
}
