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
        Vector2 moveAmount = direction * GameParameters.RodMoveSpeed * Time.deltaTime;
        RodSpriteRenderer.transform.Translate(moveAmount);
        
        RodSpriteRenderer.transform.position = SpriteTools.ConstrainToScreen(RodSpriteRenderer);
    }

    public Vector3 GetPosition()
    {
        return transform.position;
    }
}