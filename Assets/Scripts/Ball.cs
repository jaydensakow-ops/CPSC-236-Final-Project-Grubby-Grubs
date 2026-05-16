using UnityEngine;

public class Ball : MonoBehaviour
{
    public Color redTeamColor = Color.red;
    public Color blueTeamColor = Color.blue;
    public Color neutralColor = Color.white;
    
    public GameObject SmokeBubbleParticlePrefab;
    private Sounds sounds;
    private TrailRenderer trail;

    void Awake()
    {
        trail = GetComponent<TrailRenderer>();
        sounds = GetComponent<Sounds>();
        SetNeutral();
    }

    public void ChangeColor(string team)
    {
        if (team == "RedTeam")
            SetColor(redTeamColor);
        else if (team == "BlueTeam")
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
            sounds.PlaySmokebombSound();
            SpawnSmokeBubbleParticle(other.transform.position);
            Destroy(other.gameObject);
        }
    }
}
