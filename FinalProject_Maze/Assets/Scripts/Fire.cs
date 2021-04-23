using UnityEngine;
using System.Collections;
public class Fire : MonoBehaviour {
public Transform FirePoint; public Rigidbody Bullet;
// Update is called once per frame 
    void Update () {
//按空格键发射子弹
if(Input.GetKey(KeyCode.Space)){
Rigidbody clone;
clone = Instantiate(Bullet,FirePoint.position,FirePoint.rotation) as Rigidbody; clone.velocity = transform.TransformDirection(Vector3.forward*500);
 } }
}
