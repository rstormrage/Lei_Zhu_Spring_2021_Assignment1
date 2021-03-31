using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller : MonoBehaviour
{
    Vector3 velocity;
    public float moveSpeed;
    Rigidbody myRigidbody;
    Camera viewCamera;
    private GameObject gameObject;
    
    // Start is called before the first frame update
    void Start()
    {
        gameObject = GameObject.Find("Main Camera");
        myRigidbody = GetComponent<Rigidbody>();
        viewCamera = Camera.main;
        Vector3 mousePos = viewCamera.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, viewCamera.transform.position.y));
        transform.LookAt(mousePos + Vector3.up * transform.position.y);

    }

    // Update is called once per frame
    void Update()
    {
       
        Vector3 mousePos = viewCamera.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, viewCamera.transform.position.y));
        transform.LookAt(mousePos + Vector3.up * transform.position.y);
        //velocity = new Vector3(Input.GetAxisRaw("Horizontal"), 0, Input.GetAxisRaw("Vertical")).normalized * moveSpeed;
        float x = Input.GetAxis("Horizontal") * Time.deltaTime * moveSpeed;

        float z = Input.GetAxis("Vertical") * Time.deltaTime * moveSpeed;
        transform.Translate(x, 0, z);
    }

    void FisedUpdate()
    {
        myRigidbody.MovePosition(myRigidbody.position + velocity * Time.fixedDeltaTime);
    }
}
