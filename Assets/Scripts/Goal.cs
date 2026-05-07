using UnityEngine;

public class Goal : MonoBehaviour
{
    public Launcher launcher;
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Ball"))
        {
            Debug.Log("GOAL!!!");
            launcher.OnGoal();
        }
    }
}
