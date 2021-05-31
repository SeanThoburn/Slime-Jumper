using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class coin2 : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        FindObjectOfType<game2>().score += 1;
        Destroy(gameObject);
    }
}