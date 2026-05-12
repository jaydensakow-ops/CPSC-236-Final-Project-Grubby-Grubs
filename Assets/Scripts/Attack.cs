using UnityEngine;

public class Attack : MonoBehaviour
{
    public Animator Animator;
    public SwordHitBox SwordHitBox;
    
    public void Animate()
    {
	    Animator.SetBool("IsAttacking", true);
        SwordHitBox.StartAttack();
    }
    
    public void StopAnimate()
    {
        Animator.SetBool("IsAttacking", false);
        SwordHitBox.StopAttack();
    }
}
