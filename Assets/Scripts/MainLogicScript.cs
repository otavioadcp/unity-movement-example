using UnityEngine;
using UnityEngine.UI;

public class MainLogicScript : MonoBehaviour
{
    public Text scoreText;
    public int playerScore;

    [ContextMenu("Increase Score")]
    public void addScore()
    {
        playerScore++;
        scoreText.text = playerScore.ToString();
    }
}
