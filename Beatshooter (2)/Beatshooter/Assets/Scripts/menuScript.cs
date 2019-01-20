using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
public class menuScript : MonoBehaviour
{
    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.tag == "startbutton")
        {
            SceneManager.LoadScene("test");
        }
    }
}
