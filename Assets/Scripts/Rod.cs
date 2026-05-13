using UnityEngine;

public class Rod : MonoBehaviour
{
    private SpriteRenderer RodSpriteRenderer;
    
    public void Awake()
    {
        RodSpriteRenderer = GetComponent<SpriteRenderer>();
    }
    public void Move(Vector2 direction)
    {
        Vector3 moveAmount = direction * GameParameters.RodMoveSpeed * Time.deltaTime;
        
        Vector3 newPosition = transform.position + moveAmount;
        
        newPosition.y = Mathf.Clamp(newPosition.y, GameParameters.minimumYRodDistance,
            GameParameters.maximumYRodDistance);

        transform.position = newPosition;
    }
}