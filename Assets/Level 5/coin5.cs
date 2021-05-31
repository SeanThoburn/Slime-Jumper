using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class coin5 : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        FindObjectOfType<game5>().score += 1;
        Destroy(gameObject);
    }
}
