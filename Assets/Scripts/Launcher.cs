using System.Collections;
using UnityEngine;
using UnityEngine.InputSystem;
using TMPro;

public class Launcher : MonoBehaviour
{
    public GameObject ballPrefab;
    public float minLaunchForce = GameParameters.minLaunchForce;
    public float maxLaunchForce = GameParameters.maxLaunchForce;
    public float kickoffDelay = GameParameters.kickoffDelay;
    public Sounds Sounds;
    
    public TMP_Text kickoffText;

    private GameObject activeBall;
    private bool canKickoff = false;
    
   public void Kickoff()
    {
        if (canKickoff)
        {
            SpawnBall();
        }
    }
    public void OnGoal()
    {
        if (activeBall != null)
        {
            Destroy(activeBall);
            activeBall = null;
        }

        canKickoff = false;
        StartCoroutine(KickoffDelay());
    }
    private IEnumerator KickoffDelay()
    {
        yield return new WaitForSeconds(kickoffDelay);
        canKickoff = true;
        kickoffText.text = "Press Space to Kickoff!";
    }
    private void SpawnBall()
    {
        canKickoff = false;
        kickoffText.text = "";
        Sounds.PlayWhistleSound();

        activeBall = Instantiate(ballPrefab, Vector2.zero, Quaternion.identity);

        float randomAngle = Random.Range(0f, 360f) * Mathf.Deg2Rad;
        Vector2 randomDirection = new Vector2(Mathf.Cos(randomAngle), Mathf.Sin(randomAngle));
        float randomForce = Random.Range(minLaunchForce, maxLaunchForce);

        Rigidbody2D rb = activeBall.GetComponent<Rigidbody2D>();
        rb.AddForce(randomDirection * randomForce, ForceMode2D.Impulse);
    }
}
