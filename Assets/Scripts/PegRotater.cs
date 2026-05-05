using UnityEngine;

public class PegRotater : MonoBehaviour
{
    //private float currentRotation = 0f;
    //private float rotationAmount;

    
    private float targetRotation = 0f;

    public void RotatePeg()
    {
        // Rotate 90° clockwise per press
        targetRotation += GameParameters.PegRotationDirection;
    }
    void Update()
    {
        float currentZAngle = transform.eulerAngles.z;
        float newZAngle = Mathf.MoveTowardsAngle(currentZAngle, targetRotation, 
            GameParameters.PegRotationSpeed * Time.deltaTime);
        
        transform.rotation = Quaternion.Euler(0f, 0f, newZAngle);
        
        
    }
    
    
}
