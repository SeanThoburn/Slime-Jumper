using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class levelfiveend : MonoBehaviour
{
    public float level;

    public GameObject hat1;
    public GameObject hat2;



    private void FixedUpdate()
    {
        hat1.gameObject.SetActive(false);
        hat2.gameObject.SetActive(false);
 
    }


    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (level > 0)
        {
            hat1.gameObject.SetActive(true);
            Time.timeScale = 0;
        }
        else
        {
           hat2.gameObject.SetActive(true);
            Time.timeScale = 0;
        }
    }
}
