using UnityEngine;

public static class Settings
{
    // Player animation parameters
    public static int InputX;
    public static int InputY;

    public static int IsWalking;
    public static int IsRunning;
    public static int ToolEffect;

    public static int IsUsingToolRight;
    public static int IsUsingToolLeft;
    public static int IsUsingToolUp;
    public static int IsUsingToolDown;

    public static int IsLiftingToolRight;
    public static int IsLiftingToolLeft;
    public static int IsLiftingToolUp;
    public static int IsLiftingToolDown;

    public static int IsSwingingToolRight;
    public static int IsSwingingToolLeft;
    public static int IsSwingingToolUp;
    public static int IsSwingingToolDown;

    public static int IsPickingRight;
    public static int IsPickingLeft;
    public static int IsPickingUp;
    public static int IsPickingDown;

    // Shared animation parameters
    public static int IdleUp;

    public static int IdleDown;
    public static int IdleLeft;
    public static int IdleRight;

    static Settings()
    {
        InputX = Animator.StringToHash("xInput");
        InputY = Animator.StringToHash("yInput");

        IsWalking = Animator.StringToHash("isWalking");
        IsRunning = Animator.StringToHash("isRunning");
        ToolEffect = Animator.StringToHash("toolEffect");

        IsUsingToolRight = Animator.StringToHash("isUsingToolRight");
        IsUsingToolLeft = Animator.StringToHash("isUsingToolLeft");
        IsUsingToolUp = Animator.StringToHash("isUsingToolUp");
        IsUsingToolDown = Animator.StringToHash("isUsingToolDown");

        IsLiftingToolRight = Animator.StringToHash("isLiftingToolRight");
        IsLiftingToolLeft = Animator.StringToHash("isLiftingToolLeft");
        IsLiftingToolUp = Animator.StringToHash("isLiftingToolUp");
        IsLiftingToolDown = Animator.StringToHash("isLiftingToolDown");

        IsSwingingToolRight = Animator.StringToHash("isSwingingToolRight");
        IsSwingingToolLeft = Animator.StringToHash("isSwingingToolLeft");
        IsSwingingToolUp = Animator.StringToHash("isSwingingToolUp");
        IsSwingingToolDown = Animator.StringToHash("isSwingingToolDown");

        IsPickingRight = Animator.StringToHash("isPickingRight");
        IsPickingLeft = Animator.StringToHash("isPickingLeft");
        IsPickingUp = Animator.StringToHash("isPickingUp");
        IsPickingDown = Animator.StringToHash("isPickingDown");

        IdleUp = Animator.StringToHash("idleUp");
        IdleDown = Animator.StringToHash("idleDown");
        IdleLeft = Animator.StringToHash("idleLeft");
        IdleRight = Animator.StringToHash("idleRight");
    }
}