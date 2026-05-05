using UnityEngine;
using UnityEngine.InputSystem;

public class KeyboardInput : MonoBehaviour
{
    public Rod Rod;
    public PegRotater PegRotater;
    

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
            PegRotater.RotatePeg();

        }
    }
}