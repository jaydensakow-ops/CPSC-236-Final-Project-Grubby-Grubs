using UnityEngine;
using UnityEngine.InputSystem;

public class KeyboardInput : MonoBehaviour
{
    public Rod Rod1;
    public Rod Rod2;
    public Rod Rod3;
    public Rod Rod4;
    public Rod Rod5;
    public Rod Rod6;
    
    public Attack[] Attacks1;
    public Attack[] Attacks2;
    
    private Vector2 aimDirection = Vector2.up;
    
    void Update()
    {
        Keyboard keyboard = Keyboard.current;

        if (keyboard.wKey.isPressed)
        {
            Rod1.Move(Vector2.up);
            Rod2.Move(Vector2.up);
            Rod3.Move(Vector2.up);
        }

        if (keyboard.sKey.isPressed)
        {
            Rod1.Move(Vector2.down);
            Rod2.Move(Vector2.down);
            Rod3.Move(Vector2.down);
        }
        
        if (keyboard.upArrowKey.isPressed)
        {
            Rod4.Move(Vector2.up);
            Rod5.Move(Vector2.up);  
            Rod6.Move(Vector2.up);
        }

        if (keyboard.downArrowKey.isPressed)
        {
            Rod4.Move(Vector2.down);
            Rod5.Move(Vector2.down);
            Rod6.Move(Vector2.down);
        }

        if (keyboard.leftShiftKey.isPressed)
        {
            foreach (Attack attack in Attacks1)
            {
                attack.Animate();
            }
        }
        else
        {
            foreach (Attack attack in Attacks1)
            {
                attack.StopAnimate();
            }
        }
        
        if (keyboard.rightShiftKey.isPressed)
        {
            foreach (Attack attack in Attacks2)
            {
                attack.Animate();
            }
        }
        else
        {
            foreach (Attack attack in Attacks2)
            {
                attack.StopAnimate();
            }
        }
    }
}