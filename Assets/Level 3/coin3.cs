using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class coin3 : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        FindObjectOfType<game3>().score += 1;
        Destroy(gameObject);
    }
}
