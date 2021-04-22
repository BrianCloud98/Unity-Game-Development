using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    public Rigidbody2D rb;

    void FixedUpdate()
    {
        Destroy(rb.gameObject, 12);
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Frog")
        {
            Score.score += 1;
            Destroy(rb.gameObject);
        }
    }
}
