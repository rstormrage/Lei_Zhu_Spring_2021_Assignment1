
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementPlayer : MonoBehaviour
{
    // Start is called before the first frame update
    public Rigidbody rigidBody;
    public float forwardForce = 1500;
    public float sideForce = 25;

    void Start()
    {
        

        //rigidBody.useGravity = false;

        rigidBody.AddForce(0, 0, 50);
    }

    // Update is called once per frame
    void Update()
    {
        

        if (Input.GetKey(KeyCode.D))
        {
            rigidBody.AddForce(sideForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
        if (Input.GetKey(KeyCode.A))
        {
            rigidBody.AddForce(-sideForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

    }

    void FixedUpdate() 
    {
        rigidBody.AddForce(0, 0, 1500 * Time.deltaTime);

    }

}
