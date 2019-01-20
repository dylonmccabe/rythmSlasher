using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
public class death : MonoBehaviour
{
    // void OnCollisionEnter(Collision col)
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Obstacle")
        {
            
            SceneManager.LoadScene("end");
        }
    }
}
