using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float speed;
    public Rigidbody2D body;
    public float jumpforce;
    bool jump;

    public GameObject restart;

    private void Update()
    {
        jump = Input.GetKeyDown(KeyCode.UpArrow);
    }

    private void FixedUpdate()
    {
        restart.gameObject.SetActive(false);
        //Vector2 movement = new Vector2(Input.GetAxis("Horizontal") * speed,Input.GetAxis("Vertical") * speed);
        body.AddForce(new Vector2(Input.GetAxis("Horizontal") * speed, 0f)); //Input.GetAxis("Vertical") * speed));

        Collider2D[] colliders = new Collider2D[10];
        if (body.GetContacts(colliders) > 0 && jump)
        {
            body.AddForce(new Vector2(0f, jumpforce));
        }

        jump = false;

        //if (Input.GetButton("Jump"))
          //  {
        //    body.AddForce(new Vector2 = ("Vertical") * jumpforce);
        //}
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Hazard")
        {
            Time.timeScale = 0;
            restart.gameObject.SetActive(true);
        }
    }
}
