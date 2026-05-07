using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;

    public TMP_Text leftText;
    public TMP_Text rightText;

    public GameObject win;

    public int winScore = 5;
    private bool gameEnded = false;

    private void Awake()
    {
        Instance = this;
    }

    public void LeftPlayerScored()
    {
        if (gameEnded) return;

        ScoreKeeper.AddPoint(true);
        UpdateScoreUI();
        CheckWin();
    }

    public void RightPlayerScored()
    {
        if (gameEnded) return;

        ScoreKeeper.AddPoint(false);
        UpdateScoreUI();
        CheckWin();
    }

    void UpdateScoreUI()
    {
        leftText.text = "Player 1: " + ScoreKeeper.GetLeftScore();
        rightText.text = "Player 2: " + ScoreKeeper.GetRightScore();
    }

    void CheckWin()
    {
        if (ScoreKeeper.GetLeftScore() >= winScore ||
            ScoreKeeper.GetRightScore() >= winScore)
        {
            EndGame();
        }
    }

    void EndGame()
    {
        gameEnded = true;
        win.SetActive(true);
    }

    public void StartNewGame()
    {
        gameEnded = false;
        win.SetActive(false);

        ScoreKeeper.ResetScore();
        UpdateScoreUI();
    }
}