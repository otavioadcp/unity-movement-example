using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainLogicScript : MonoBehaviour
{
    public Text scoreText;
    public int playerScore;

    public GameObject gameOverScreen;

    [ContextMenu("Increase Score")]
    public void addScore()
    {
        playerScore++;
        scoreText.text = playerScore.ToString();
    }

    [ContextMenu("Restart Game")]
    public void restartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    [ContextMenu("Game Over")]
    public void gameOver()
    {
        gameOverScreen.SetActive(true);
    }
}
