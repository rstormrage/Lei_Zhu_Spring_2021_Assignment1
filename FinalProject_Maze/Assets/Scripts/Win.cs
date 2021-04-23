using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
public class Win : MonoBehaviour
{
    void OnTriggerEnter(Collider otherObject)
    {
		if (otherObject.name == "Plane") SceneManager.LoadScene(4);
    }
}
