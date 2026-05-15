using UnityEngine;

public class Ball : MonoBehaviour
{
    public Color redTeamColor = Color.red;
    public Color blueTeamColor = Color.blue;
    public Color neutralColor = Color.white;
    
    public GameObject SmokeBubbleParticlePrefab;

    private TrailRenderer trail;

    void Awake()
    {
        trail = GetComponent<TrailRenderer>();
        SetNeutral();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("RedTeam"))
            SetColor(redTeamColor);
        else if (collision.gameObject.CompareTag("BlueTeam"))
            SetColor(blueTeamColor);
    }
    
    private void SetColor(Color color)
    {
        trail.startColor = color;
        trail.endColor = color;
    }
    private void SetNeutral()
    {
        trail.startColor = neutralColor;
        trail.endColor = neutralColor;
    }
    
    private void SpawnSmokeBubbleParticle(Vector3 position)
    {
        Instantiate(SmokeBubbleParticlePrefab, position, Quaternion.identity);
    }
    
    public void OnTriggerEnter2D(Collider2D other)
    {
        
        if (other.tag == "Smokebomb")
        {
            SpawnSmokeBubbleParticle(other.transform.position);
            Destroy(other.gameObject);
        }
    }
}
