using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class endgame : MonoBehaviour {

    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.tag == "backwall")
        {
            SceneManager.LoadScene("win");
            Destroy(col.gameObject);
        }
    }
}
