using UnityEngine;

public class IKController : MonoBehaviour
{
    Animator animator;
    public Transform targetHand; // Assign in Inspector

    void Start()
    {
        animator = GetComponent<Animator>();
    }

    void OnAnimatorIK(int layerIndex)
    {
        if (animator)
        {
            animator.SetIKPositionWeight(AvatarIKGoal.RightHand, 1);
            animator.SetIKPosition(AvatarIKGoal.RightHand, targetHand.position);
        }
    }
}
