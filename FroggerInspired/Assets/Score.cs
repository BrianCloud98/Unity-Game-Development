using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public Text gameOverText;

    public static int score = 0;
    public Text scoreText;

    private void Update()
    {
        gameOverText.text = $"You racked up {score} points!";
        scoreText.text = score.ToString();
    }
}
