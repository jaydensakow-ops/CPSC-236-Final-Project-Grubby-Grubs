using UnityEngine;

public class FollowBall : MonoBehaviour
{
    private Transform ball;

    void Update()
    {
        // If no ball exists yet, keep searching
        if (ball == null)
        {
            GameObject ballObject = GameObject.FindWithTag("Ball");

            if (ballObject != null)
            {
                ball = ballObject.transform;
            }

            return;
        }

        // Check if ball is to the left or right
        if (ball.position.x > transform.position.x)
        {
            // Face right
            transform.rotation = Quaternion.Euler(0, 180, 0);
        }
        else
        {
            // Face left
            transform.rotation = Quaternion.Euler(0, 0, 0);
        }
    }
}
