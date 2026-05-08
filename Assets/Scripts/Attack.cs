using UnityEngine;

public class Attack : MonoBehaviour
{
    public Animator Animator;
    
    public void Animate()
    {
	    Animator.SetBool("IsAttacking", true);
    }
    
    public void StopAnimate()
    {
        Animator.SetBool("IsAttacking", false);
    }
}
