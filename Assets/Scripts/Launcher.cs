using System.Collections;
using UnityEngine;
using UnityEngine.InputSystem;

public class Launcher : MonoBehaviour
{
    public GameObject ballPrefab;
    public float minLaunchForce = 3f;
    public float maxLaunchForce = 10f;
    public float kickoffDelay = 1.5f;

    private GameObject activeBall;
    private bool canKickoff = false;
    
    void Start()
    {
        StartCoroutine(KickoffDelay()); // Delay before very first kickoff too
    }
    void Update()
    {
        if (canKickoff && Mouse.current.leftButton.wasPressedThisFrame)
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
        Debug.Log("Click to kickoff!");
    }
    private void SpawnBall()
    {
        canKickoff = false;

        activeBall = Instantiate(ballPrefab, Vector2.zero, Quaternion.identity);

        float randomAngle = Random.Range(0f, 360f) * Mathf.Deg2Rad;
        Vector2 randomDirection = new Vector2(Mathf.Cos(randomAngle), Mathf.Sin(randomAngle));
        float randomForce = Random.Range(minLaunchForce, maxLaunchForce);

        Rigidbody2D rb = activeBall.GetComponent<Rigidbody2D>();
        rb.AddForce(randomDirection * randomForce, ForceMode2D.Impulse);
    }
}
