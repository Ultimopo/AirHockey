using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Goal : MonoBehaviour
{
    public int score1;
    public int score2;
    public TextMeshPro scoreUI;
    public TextMeshPro scoreUI1;

    private void OnCollisionEnter2D(Collision2D other)
    {

        scoreUI.text = score1.ToString();
        scoreUI1.text = score2.ToString();

        if (other.gameObject.name.Contains("Goal"))
        {
            transform.position = Vector2.zero;
        }

        if (other.gameObject.name.Contains("PZone")) 
        {

                score1++;
   
        }

        if (other.gameObject.name.Contains("EZone")) 
        {

                score2++;

        }
    }
}
