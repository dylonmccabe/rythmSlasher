using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System;

public class CollisionScriptred : MonoBehaviour
{
    private int score;
    public Text scoreText;
    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.tag == "redTarget")
        {
            score = score + 1;
            Destroy(col.gameObject);
            SetScoreText();
        }
        if (col.gameObject.tag == "targetback")
        {
            score = score + 1;
            Destroy(col.gameObject);
            SetScoreText();
        }
    }

    private void SetScoreText()
    {
        scoreText.text = "Red: " + score.ToString();
    }
}
