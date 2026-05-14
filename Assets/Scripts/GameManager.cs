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
    
    public Launcher Launcher;
    public SmokebombPlacer SmokebombPlacer;
    

    public int winScore = 1;
    
    private bool gameEnded = false;

    private void Awake()
    {
        Instance = this;
    }
    
    
    // Button
    public void OnPlayButtonClicked()
    {
        GameManager.Instance.StartGame();
        InitializeGame();
    }
    
    public void PlayAgain()
    {
        StartGame();
    }
    
    
    // Game Setup
    
    public void InitializeGame()
    { ;
        StartPlacers();
    }
    
    private void StartPlacers()
    {
        SmokebombPlacer.StartPlacing();
        
    }
    
    private void StopPlacers()
    {
        SmokebombPlacer.StopPlacing();
        
    }
    
    
    // Game
    
    public void StartGame()
    {
        gameEnded = false;
        ScoreKeeper.ResetScore();
        UpdateScoreUI();
        
        ResetUI();
        Launcher.OnGoal();
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
    
    //Score
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

    
    // UI
    
    public void ResetUI()
    {
        winPanel.SetActive(false);
        CanvasGroupDisplayer.Hide(StartScreenCanvasGroup);
    }
    
}