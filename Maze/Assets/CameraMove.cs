using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMove : MonoBehaviour
{
    public float speed = 2;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float x = Input.GetAxis("Horizontal") * Time.deltaTime * speed;

        float z = Input.GetAxis("Vertical") * Time.deltaTime * speed;

        transform.Translate(x, 0, z);

        if (Input.GetKey(KeyCode.Q))

        {

            transform.Rotate(0, -50 * Time.deltaTime, 0, Space.Self);

        }

        if (Input.GetKey(KeyCode.E))

        {

            transform.Rotate(0, 50 * Time.deltaTime, 0, Space.Self);

        }

        

       


    }

}
