using UnityEngine;

public class Rod : MonoBehaviour
{
    private SpriteRenderer RodSpriteRenderer;

    public float minX = -7f;
    public float maxX = 7f;
    public float minY = -0.1f;
    public float maxY = 0.1f;
    
    public void Awake()
    {
        RodSpriteRenderer = GetComponent<SpriteRenderer>();
    }
    public void Move(Vector2 direction)
    {
        Vector3 moveAmount = direction * GameParameters.RodMoveSpeed * Time.deltaTime;
        
        Vector3 newPosition = transform.position + moveAmount;

        newPosition.x = Mathf.Clamp(newPosition.x, minX, maxX);
        newPosition.y = Mathf.Clamp(newPosition.y, minY, maxY);

        transform.position = newPosition;
    }

    public Vector3 GetPosition()
    {
        return transform.position;
    }
}