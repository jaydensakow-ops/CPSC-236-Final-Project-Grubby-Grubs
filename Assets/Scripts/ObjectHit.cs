using UnityEngine;

public class ObjectHit : MonoBehaviour

{
    
    public float forceStrength = 10f; 

    /*
    public void ApplyForce(GameObject target, Vector3 sourcePosition)
    {
        Rigidbody2D rb = target.GetComponent<Rigidbody2D>();

        if (rb != null)
        {
            Vector2 direction = (target.transform.position - sourcePosition).normalized;
            rb.AddForce(direction * forceStrength, ForceMode2D.Impulse);
        }
    }
    */
}
