using System.Collections.Generic;
using UnityEngine;

public class Peg : MonoBehaviour
{
    public List<Sprite> Sprites;
    public GameObject RingParticlePrefab;
    
    private int currentSpriteNumber = 0;
    private SpriteRenderer spriteRenderer;

    public void Start()
    {
        //spriteRenderer = GetComponent<SpriteRenderer>();
        //spriteRenderer.sprite = Sprites[currentSpriteNumber];
    }
    
    /*
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Ball"))
        {
            Debug.Log("Hit");

            ObjectHit hitScript = GetComponent<ObjectHit>();

            if (hitScript != null)
            {
                hitScript.ApplyForce(other.gameObject, transform.position);
            }
        }
    }
    */
    
    /*
    private void SpawnRingParticle()
    {
        Instantiate(RingParticlePrefab, transform.position, Quaternion.identity);
    }
    
    private void ShowNextSprite()
    {
        currentSpriteNumber = currentSpriteNumber + 1;
        spriteRenderer.sprite = Sprites[currentSpriteNumber];
    }

    private bool NoMoreSprites()
    {
        if (currentSpriteNumber == 2) 
            return true;
        return false;
    }
    */
}