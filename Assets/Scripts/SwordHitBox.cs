using UnityEngine;

public class SwordHitBox : MonoBehaviour
{
    public float forceStrength = 10f;
    private bool isAttacking = false;
    private bool hasHit = false;

    public void StartAttack()
    {
        isAttacking = true;
        hasHit = false;
    }

    public void StopAttack()
    {
        isAttacking = false;
    }

    private void OnTriggerStay2D(Collider2D other)
    {
        if (!isAttacking || hasHit)
            return;

        if (other.CompareTag("Ball"))
        {
            Rigidbody2D rb = other.GetComponent<Rigidbody2D>();
            

            if (rb != null)
            {
                Vector2 direction = other.transform.position - transform.position;
                rb.AddForce(direction.normalized * forceStrength, ForceMode2D.Impulse);
                Ball ball = other.GetComponent<Ball>();
                if (ball != null)
                    ball.ChangeColor(gameObject.tag);
                hasHit = true;
            }
        }
    }
}
