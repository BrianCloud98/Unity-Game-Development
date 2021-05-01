using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fruit : MonoBehaviour
{
    public GameObject fruitSlicedPrefab;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Blade")
        {
            Destroy(gameObject);
            Instantiate(fruitSlicedPrefab, transform.position, transform.rotation);
        }
    }


}
