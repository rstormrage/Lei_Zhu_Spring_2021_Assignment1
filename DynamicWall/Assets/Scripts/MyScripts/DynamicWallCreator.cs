using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class DynamicWallCreator : MonoBehaviour
{
    private bool creating = false;
    public GameObject start, end;

    private Camera camera;

    public GameObject wallPrefab;
    private GameObject wall;

    // Start is called before the first frame update
    void Start()
    {
        camera = GetComponent<Camera>();

        wall = (GameObject)Instantiate(wallPrefab, start.transform.position, Quaternion.identity);
    }

    // Update is called once per frame
    void Update()
    {
        getInput();
    }

    void getInput()
    {
        if (Input.GetMouseButtonDown(0))
        {
            setStart();
        }
        else if (Input.GetMouseButtonUp(0))
        {
            setEnd();
        }
        else
        {
            if (creating)
            {
                adjust();
            }
        }
    }

    void setStart()
    {
        creating = true;

        start.transform.position = getWorldPoint();
    }

    void setEnd()
    {
        creating = false;

        end.transform.position = getWorldPoint();
    }

    void adjust()
    {
        end.transform.position = getWorldPoint();

        start.transform.LookAt(end.transform);
        float distance = Vector3.Distance(start.transform.position, end.transform.position);
        wall.transform.position = start.transform.position + distance / 2 * start.transform.forward;
        wall.transform.rotation = start.transform.rotation;

        wall.transform.localScale = new Vector3(wall.transform.localScale.x, wall.transform.localScale.y, distance);

    }

    Vector3 getWorldPoint()
    {

        RaycastHit hit;

        Ray ray = camera.ScreenPointToRay(Input.mousePosition);

        if (Physics.Raycast(ray, out hit))
        {
            return hit.point;
        }

        return Vector3.zero;
    }
}
