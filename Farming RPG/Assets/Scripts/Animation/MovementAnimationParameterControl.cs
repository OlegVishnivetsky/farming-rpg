using UnityEngine;

public class MovementAnimationParameterControl : MonoBehaviour
{
    private Animator animator;

    private void Awake()
    {
        animator = GetComponent<Animator>();
    }

    private void OnEnable()
    {
        StaticEventsHandler.MovementAnimationEvent += SetAnimationParameters;
    }

    private void OnDisable()
    {
        StaticEventsHandler.MovementAnimationEvent -= SetAnimationParameters;
    }

    private void SetAnimationParameters(float inputX, float inputY, bool isWalking, bool isRunning, bool isIdle, 
        bool isCarrying, ToolEffect toolEffect, 
        bool isUsingToolRight, bool isUsingToolLeft, bool isUsingToolUp, bool isUsingToolDown, 
        bool isLiftingToolRight, bool isLiftingToolLeft, bool isLiftingToolUp, bool isLiftingToolDown, 
        bool isPickingRight, bool isPickingLeft, bool isPickingUp, bool isPickingDown, 
        bool isSwingingToolRight, bool isSwingingToolLeft, bool isSwingingToolUp, bool isSwingingToolDown, 
        bool isIdleRight, bool isIdleLeft, bool isIdleUp, bool isIdleDown)
    {
        animator.SetFloat(Settings.InputX, inputX);
        animator.SetFloat(Settings.InputY, inputY);

        animator.SetBool(Settings.IsWalking, isWalking);
        animator.SetBool(Settings.IsRunning, isRunning);

        animator.SetInteger(Settings.ToolEffect, (int)toolEffect);

        if (isUsingToolRight)
            animator.SetTrigger(Settings.IsUsingToolRight);
        if (isUsingToolLeft)
            animator.SetTrigger(Settings.IsUsingToolLeft);
        if (isUsingToolUp)
            animator.SetTrigger(Settings.IsUsingToolUp);
        if (isUsingToolDown)
            animator.SetTrigger(Settings.IsUsingToolDown);

        if (isLiftingToolRight)
            animator.SetTrigger(Settings.IsLiftingToolRight);
        if (isLiftingToolLeft)
            animator.SetTrigger(Settings.IsLiftingToolLeft);
        if (isLiftingToolUp)
            animator.SetTrigger(Settings.IsLiftingToolUp);
        if (isLiftingToolDown)
            animator.SetTrigger(Settings.IsLiftingToolDown);

        if (isPickingRight)
            animator.SetTrigger(Settings.IsPickingRight);
        if (isPickingLeft)
            animator.SetTrigger(Settings.IsPickingLeft);
        if (isPickingUp)
            animator.SetTrigger(Settings.IsPickingUp);
        if (isPickingDown)
            animator.SetTrigger(Settings.IsPickingDown);

        if (isSwingingToolRight)
            animator.SetTrigger(Settings.IsSwingingToolRight);
        if (isSwingingToolLeft)
            animator.SetTrigger(Settings.IsSwingingToolLeft);
        if (isSwingingToolUp)
            animator.SetTrigger(Settings.IsSwingingToolUp);
        if (isSwingingToolDown)
            animator.SetTrigger(Settings.IsSwingingToolDown);

        if (isIdleRight)
            animator.SetTrigger(Settings.IdleRight);
        if (isIdleLeft)
            animator.SetTrigger(Settings.IdleLeft);
        if (isIdleUp)
            animator.SetTrigger(Settings.IdleUp);
        if (isIdleDown)
            animator.SetTrigger(Settings.IdleDown);
    }

    public void AnimationEventPlayFootstepSound()
    {
        
    }
}