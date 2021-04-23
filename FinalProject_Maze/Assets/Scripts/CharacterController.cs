using UnityEngine;
using System.Collections;
public class CharacterController : MonoBehaviour
{
    public GameObject Insert;
    public GUIStyle myStyle;
    private float mytime;
    // Use this for initialization 
    void Start()
    {
        mytime = 120.0f;
        InvokeRepeating("count", 0, 1);
    }
    // Update is called once per frame 
    void Update()
    {
        //如果实例化失败，直接返回 
        if (Insert == null)
        {
            return;
        }
        //以下代码控制 Insert 运动
        if (Input.GetKey(KeyCode.W))
        {
            Insert.transform.Translate(Vector3.forward * Time.deltaTime * 80);
        }
        else if (Input.GetKey(KeyCode.S))
        {
            Insert.transform.Translate(Vector3.forward * Time.deltaTime * -80);
        }
        else if (Input.GetKey(KeyCode.A))
        {
            Insert.transform.Rotate(Vector3.up * Time.deltaTime * -50);
        }
        else if (Input.GetKey(KeyCode.D))
        {
            Insert.transform.Rotate(Vector3.up * Time.deltaTime * 50);
        }
    }
}