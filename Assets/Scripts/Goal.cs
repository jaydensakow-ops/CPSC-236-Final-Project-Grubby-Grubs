using UnityEngine;

public class Goal : MonoBehaviour
{
    public Sounds Sounds;
    public Launcher launcher;

    public bool isLeftGoal;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Ball"))
        {
            Debug.Log("GOAL!!!");
            Sounds.PlayPointsSound();
            Sounds.PlayBallGoalSound();

            if (isLeftGoal)
            {
                GameManager.Instance.RightPlayerScored();
            }
            else
            {
                GameManager.Instance.LeftPlayerScored();
            }
            
            launcher.OnGoal();
        }
    }
}