using UnityEngine;
using UnityEngine.SceneManagement;

public class Frog : MonoBehaviour
{
    public Rigidbody2D rb;
    public GameObject gameOverPanel;

    private void Start()
    {
        gameOverPanel.SetActive(false);
    }

    void Update()
    {

        if (Input.GetKeyDown(KeyCode.D))
        {
            if (rb.position.x < 15)
            {
                rb.MovePosition(rb.position + Vector2.right);
            }
        }
        else if (Input.GetKeyDown(KeyCode.A))
        {
            if (rb.position.x > -15)
            {
                rb.MovePosition(rb.position + Vector2.left);
            }
        }
        else if (Input.GetKeyDown(KeyCode.W))
        {
            if (rb.position.y < 6.15)
            {
                rb.MovePosition(rb.position + Vector2.up);
            }
        }
        else if (Input.GetKeyDown(KeyCode.S))
        {
            if (rb.position.y > -6.15)
            {
                rb.MovePosition(rb.position + Vector2.down);
            }
        }
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Car")
        {
            gameOverPanel.SetActive(true);
            Time.timeScale = 0;
        }
    }

}
