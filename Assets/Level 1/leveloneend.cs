using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class leveloneend : MonoBehaviour
{
    public float level;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(level > 0)
        {
            SceneManager.LoadScene("Level 2 1");
        }
        else
        {
            SceneManager.LoadScene("Level 2 2");
        }
    }
}
