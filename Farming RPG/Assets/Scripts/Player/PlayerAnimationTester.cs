using UnityEngine;

public class PlayerAnimationTester : MonoBehaviour
{
    [SerializeField] private float inputX;
    [SerializeField] private float inputY;

    [Space(5)]
    [SerializeField] private bool isWalking;
    [SerializeField] private bool isRunning;
    [SerializeField] private bool isIdle;
    [SerializeField] private bool isCarrying;
    [SerializeField] private ToolEffect toolEffect;

    [Space(5)]
    [SerializeField] private bool isUsingToolRight;
    [SerializeField] private bool isUsingToolLeft;
    [SerializeField] private bool isUsingToolUp;
    [SerializeField] private bool isUsingToolDown;

    [Space(5)]
    [SerializeField] private bool isLiftingToolRight;
    [SerializeField] private bool isLiftingToolLeft;
    [SerializeField] private bool isLiftingToolUp;
    [SerializeField] private bool isLiftingToolDown;

    [Space(5)]
    [SerializeField] private bool isSwingingToolRight;
    [SerializeField] private bool isSwingingToolLeft;
    [SerializeField] private bool isSwingingToolUp;
    [SerializeField] private bool isSwingingToolDown;

    [Space(5)]
    [SerializeField] private bool isPickingRight;
    [SerializeField] private bool isPickingLeft;
    [SerializeField] private bool isPickingUp;
    [SerializeField] private bool isPickingDown;

    [Space(5)]
    [SerializeField] private bool idleRight;
    [SerializeField] private bool idleLeft;
    [SerializeField] private bool idleUp;
    [SerializeField] private bool idleDown;

    private void Update()
    {
        StaticEventsHandler.InvokeMovementAnimationEvent(inputX, inputY, isWalking, isRunning, isIdle, isCarrying, toolEffect, 
            isUsingToolRight, isUsingToolLeft, isUsingToolUp, isUsingToolDown, 
            isLiftingToolRight, isLiftingToolLeft, isLiftingToolUp, isLiftingToolDown, 
            isPickingRight, isPickingLeft, isPickingUp, isPickingDown, 
            isSwingingToolRight, isSwingingToolLeft, isSwingingToolUp, isSwingingToolDown, 
            idleRight, idleLeft, idleUp, idleDown);
    }
}