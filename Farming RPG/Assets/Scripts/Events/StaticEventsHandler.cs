public delegate void MovementAnimationDelegate(float inputX, float inputY, bool isWalking, bool isRunning, bool isIdle, 
    bool isCarrying,ToolEffect toolEffect, 
    bool isUsingToolRight, bool isUsingToolLeft, bool isUsingToolUp, bool isUsingToolDown, 
    bool isLiftingToolRight, bool isLiftingToolLeft, bool isLiftingToolUp, bool isLiftingToolDown, 
    bool isPickingRight, bool isPickingLeft, bool isPickingUp, bool isPickingDown, 
    bool isSwingingToolRight, bool isSwingingToolLeft, bool isSwingingToolUp, bool isSwingingToolDown,
    bool isIdleRight, bool isIdleLeft, bool isIdleUp, bool isIdleDown);

public static class StaticEventsHandler
{
    public static event MovementAnimationDelegate MovementAnimationEvent;

    public static void InvokeMovementAnimationEvent(float inputX, float inputY, bool isWalking, bool isRunning, bool isIdle, 
        bool isCarrying, ToolEffect toolEffect,
    bool isUsingToolRight, bool isUsingToolLeft, bool isUsingToolUp, bool isUsingToolDown,
    bool isLiftingToolRight, bool isLiftingToolLeft, bool isLiftingToolUp, bool isLiftingToolDown,
    bool isPickingRight, bool isPickingLeft, bool isPickingUp, bool isPickingDown,
    bool isSwingingToolRight, bool isSwingingToolLeft, bool isSwingingToolUp, bool isSwingingToolDown,
    bool isIdleRight, bool isIdleLeft, bool isIdleUp, bool isIdleDown)
    {
        MovementAnimationEvent?.Invoke(inputX, inputY, isWalking, isRunning, isIdle, 
            isCarrying, toolEffect, 
            isUsingToolRight, isUsingToolLeft, isUsingToolUp, isUsingToolDown, 
            isLiftingToolRight, isLiftingToolLeft, isLiftingToolUp, isLiftingToolDown, 
            isPickingRight, isPickingLeft, isPickingUp, isPickingDown, 
            isSwingingToolRight, isSwingingToolLeft, isSwingingToolUp, isSwingingToolDown, 
            isIdleRight, isIdleLeft, isIdleUp, isIdleDown);
    }
}