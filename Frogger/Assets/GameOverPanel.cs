using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverPanel : MonoBehaviour
{
    public GameObject gameOverPanel;
    
    public void OnClickContinue()
    {
        gameOverPanel.SetActive(false);
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        Score.score = 0;
        Time.timeScale = 1;
    }

    public void OnClickExit()
    {
        Application.Quit();
    }
}
