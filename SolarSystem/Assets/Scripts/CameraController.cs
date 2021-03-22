using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public float viewspeed;
    public float movespeed;
    private Camera camera;
    // Start is called before the first frame update
    void Start()
    {
        camera = GetComponentInChildren<Camera>();
    }

    // Update is called once per frame
    void Update()
    {
        float mouseX = Input.GetAxis("Mouse X") * viewspeed;
        float mouseY = Input.GetAxis("Mouse Y") * viewspeed;
        
        camera.transform.localRotation = camera.transform.localRotation * Quaternion.Euler(-mouseY, 0, 0);
        transform.localRotation = transform.localRotation * Quaternion.Euler(0, mouseX, 0);

        float x = Input.GetAxis("Horizontal") * Time.deltaTime * movespeed;

        float z = Input.GetAxis("Vertical") * Time.deltaTime * movespeed;

        transform.Translate(x, 0, z);

        if (Input.GetKey(KeyCode.Q))

        {

            transform.Rotate(0, -150 * Time.deltaTime, 0, Space.Self);

        }

        if (Input.GetKey(KeyCode.E))

        {

            transform.Rotate(0, 150 * Time.deltaTime, 0, Space.Self);

        }
    }
}
