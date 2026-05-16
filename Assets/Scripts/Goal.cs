using UnityEngine;
using TMPro;
public class Goal : MonoBehaviour
{
    public Sounds sounds;
    public Launcher launcher;

    public bool isLeftGoal;

    public GameObject fireworkParticlesPrefab;
    public TMP_Text goalText;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Ball"))
        {
            goalText.text = "GOAL!";
            
            // Spawn fireworks
            SpawnParticles(other);

            // Play sounds
            sounds.PlayPointsSound();
            sounds.PlayBallGoalSound();

            // Score
            if (isLeftGoal)
            {
                GameManager.Instance.RightPlayerScored();
            }
            else
            {
                GameManager.Instance.LeftPlayerScored();
            }
            
            Destroy(other.gameObject);
            
            launcher.OnGoal();
        }
    }

    private void SpawnParticles(Collider2D ball)
    {
        if (fireworkParticlesPrefab == null)
        {
            Debug.LogWarning("Firework Particle Prefab is missing!");
            return;
        }

        Vector3 particlePosition = GetParticlesPosition(ball);

        Instantiate(fireworkParticlesPrefab, particlePosition, Quaternion.identity);
    }

    private Vector3 GetParticlesPosition(Collider2D ball)
    {
        Vector3 ballPosition = ball.transform.position;
        ballPosition.y += 0.25f;

        return ballPosition;
    }
}