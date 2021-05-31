using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gobbo : MonoBehaviour
{
    public AudioSource audio;
    public AudioClip speech;

    private void Start()
    {
        audio = GetComponent<AudioSource>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(speech != null)
        {
            audio.PlayOneShot(speech, 0.7f);
        }
    }

}
