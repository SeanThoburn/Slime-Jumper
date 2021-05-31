using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class game2 : MonoBehaviour
{
    public int score;
    public Text scoretext;

    private void FixedUpdate()
    {
        scoretext.text = score.ToString();

        if (score > 8)
        {
            FindObjectOfType<leveltwoend>().level += 1;
        }

    }
}
