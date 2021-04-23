using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject player;
    private Vector3 temp;
    private Vector3 temporg;
    public float zoomspeed = 0.2f;//用于开始移动相机的缓冲时间 
    public float m_DampTime = 0.02f;
    private Camera Main_Camera;
    private Vector3 target;

    // Start is called before the first frame update
    void Start()
    {
        Main_Camera = GetComponent<Camera>();
        temp = transform.position - player.transform.position;//得到相机和跟随角色之间的位置位差变量
        temporg = temp * 0.2f;

    }

    // Update is called once per frame
    void Update()
    {
        target = player.transform.position + temp;


        if (Input.GetAxis("Mouse ScrollWheel") > 0)//滚轮实现缩放
        {

            temp = temp + temporg;
            target = player.transform.position + temp;
            transform.position = Vector3.Lerp(transform.position, target, zoomspeed);
        }
        if (Input.GetAxis("Mouse ScrollWheel") < 0)
        {

            temp = temp - temporg;
            target = player.transform.position + temp;
            transform.position = Vector3.Lerp(transform.position, target, zoomspeed);

        }




        transform.position = Vector3.Lerp(transform.position, target, m_DampTime);

        float mx = Input.GetAxis("Mouse X");
        Quaternion q = Quaternion.Euler(0, mx, 0);//通过鼠标移动构造旋转四元数
        //transform.rotation = player.transform.rotation;
        //transform.rotation = Quaternion.Euler(Vector3.right * 20);
        transform.rotation = q * transform.rotation;//四元数点乘角度旋转得到新旋转


    }
}
