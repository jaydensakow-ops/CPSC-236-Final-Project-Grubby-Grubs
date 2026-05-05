using UnityEngine;
using UnityEngine.InputSystem;

public class KeyboardInput : MonoBehaviour
{
    public LegPlacer LegPlacer;
    public Rod Rod;
    
    private Vector2 aimDirection = Vector2.up;
    
    void Update()
    {
        Keyboard keyboard = Keyboard.current;

        if (keyboard.wKey.isPressed)
        {
            Rod.Move(Vector2.up);
        }

        if (keyboard.sKey.isPressed)
        {
            Rod.Move(Vector2.down);
        }

        if (keyboard.aKey.isPressed)
        {
            Rod.Move(Vector2.left);
        }

        if (keyboard.dKey.isPressed)
        {
            Rod.Move(Vector2.right);
        }

        if (keyboard.spaceKey.wasPressedThisFrame)
        {
            LegPlacer.PlaceLeg(Rod.transform.position);
        }
    }
}