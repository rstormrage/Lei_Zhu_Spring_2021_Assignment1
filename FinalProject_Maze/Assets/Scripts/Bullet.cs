using UnityEngine;
using System.Collections;
public class Bullet : MonoBehaviour
{
    Collider otherObject;
    void OnCollisionStay(Collision collisionInfo)
    {
        Destroy(gameObject);
    }
    void OnTriggerEnter(Collider otherObject)
    {
        Destroy(otherObject.GetComponent<Collider>().gameObject);
    }
}
