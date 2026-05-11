using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;
    
    public TMP_Text winText;
    public TMP_Text leftText;
    public TMP_Text rightText;
    
    public CanvasGroup StartScreenCanvasGroup;
    public GameObject winPanel;
    

    public int winScore = 1;
    private bool gameEnded = false;

    private void Awake()
    {
        Instance = this;
    }

    public void ResetUI()
    {
        winPanel.SetActive(false);
        CanvasGroupDisplayer.Hide(StartScreenCanvasGroup);
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

    public void StartNewGame()
    {
        StartGame();
        
    }

    public void StartGame()
    {
        gameEnded = false;
        ScoreKeeper.ResetScore();
        UpdateScoreUI();
        
        ResetUI();
        
    }

    public void PlayAgain()
    {
        StartGame();
    }
    

    public void EndGame()
    {
        gameEnded = true;
        winPanel.SetActive(true);

        if (ScoreKeeper.GetLeftScore() >= winScore)
        {
            winText.text = "Player 1 Wins!";
        }
        else
        {
            winText.text = "Player 2 Wins!";
        }
        
    }
    
}