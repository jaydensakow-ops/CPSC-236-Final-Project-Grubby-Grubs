using UnityEngine;

public class Game : MonoBehaviour
{
    public SmokebombPlacer SmokebombPlacer;
    
    public void OnPlayButtonClicked()
    {
        GameManager.Instance.StartGame();
        InitializeGame();
    }
    
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
}
