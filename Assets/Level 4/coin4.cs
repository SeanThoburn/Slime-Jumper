using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class coin4 : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        FindObjectOfType<game4>().score += 1;
        Destroy(gameObject);
    }
}
