using UnityEngine;
using UnityEngine.InputSystem;

public class KeyboardInput : MonoBehaviour
{
    public LegPlacer LegPlacer;
    public Rod Rod1;
    public Rod Rod2;
    public Rod Rod3;
    public Rod Rod4;
    
    private Vector2 aimDirection = Vector2.up;
    
    void Update()
    {
        Keyboard keyboard = Keyboard.current;

        if (keyboard.wKey.isPressed)
        {
            Rod1.Move(Vector2.up);
            Rod2.Move(Vector2.up);
        }

        if (keyboard.sKey.isPressed)
        {
            Rod1.Move(Vector2.down);
            Rod2.Move(Vector2.down);
        }
        
        if (keyboard.upArrowKey.isPressed)
        {
            Rod3.Move(Vector2.up);
            Rod4.Move(Vector2.up);
        }

        if (keyboard.downArrowKey.isPressed)
        {
            Rod3.Move(Vector2.down);
            Rod4.Move(Vector2.down);
        }

        if (keyboard.spaceKey.wasPressedThisFrame)
        {
            LegPlacer.PlaceLeg(Rod1.transform.position);
            LegPlacer.PlaceLeg(Rod2.transform.position);
        }
    }
}