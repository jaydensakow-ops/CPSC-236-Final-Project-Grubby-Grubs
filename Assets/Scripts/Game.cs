using UnityEngine;

public class Game : MonoBehaviour
{
    public void OnPlayButtonClicked()
    {
        GameManager.Instance.StartGame();
    }
}
