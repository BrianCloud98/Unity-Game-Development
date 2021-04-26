using UnityEngine;
using UnityEngine.SceneManagement;

public class EndGoal : MonoBehaviour
{
    void OnTriggerEnter2D ()
    {
        Debug.Log("You Win!!");
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
