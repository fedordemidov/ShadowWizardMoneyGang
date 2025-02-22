using UnityEngine;

public class AnimatorActivator : MonoBehaviour
{
    [SerializeField] private Animator animator;
    [SerializeField] private Enemy enemy;

    void Update()
    {
        if (animator != null && enemy != null)
        {
            animator.SetBool("run", enemy.pursuit);
        }
    }

    public void DeathAnimation()
    {
        animator.SetBool("deth", true);
    }
}
