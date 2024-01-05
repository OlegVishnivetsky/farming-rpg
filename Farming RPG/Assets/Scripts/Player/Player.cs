using UnityEngine;

public class Player : SingletonMonoBehaviour<Player>
{
    [SerializeField] private float runningSpeed;
    [SerializeField] private float walkingSpeed;

    private float currentMoveSpeed;

    private new Rigidbody2D rigidbody2D;

    private Direction direction;

    private bool _isInputDisabled = false;
    public bool IsInputDisabled { get => _isInputDisabled; set => _isInputDisabled = value; }

    #region Movement Animation Parameters
    private float inputX;
    private float inputY;

    private bool isWalking;
    private bool isRunning;
    private bool isIdle;
    private bool isCarrying;
    private ToolEffect toolEffect;

    private bool isUsingToolRight;
    private bool isUsingToolLeft;
    private bool isUsingToolUp;
    private bool isUsingToolDown;

    private bool isLiftingToolRight;
    private bool isLiftingToolLeft;
    private bool isLiftingToolUp;
    private bool isLiftingToolDown;

    private bool isSwingingToolRight;
    private bool isSwingingToolLeft;
    private bool isSwingingToolUp;  
    private bool isSwingingToolDown;

    private bool isPickingRight;
    private bool isPickingLeft;
    private bool isPickingUp;
    private bool isPickingDown;

    private bool idleRight;
    private bool idleLeft;
    private bool idleUp;
    private bool idleDown;
    #endregion

    protected override void Awake()
    {
        base.Awake();

        rigidbody2D = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        ResetAnimationTriggers();
        HandleMovementInput();
        HandleWalkInput();

        StaticEventsHandler.InvokeMovementAnimationEvent(inputX, inputY, isWalking, isRunning, isIdle, isCarrying, toolEffect,
            isUsingToolRight, isUsingToolLeft, isUsingToolUp, isUsingToolDown,
            isLiftingToolRight, isLiftingToolLeft, isLiftingToolUp, isLiftingToolDown,
            isPickingRight, isPickingLeft, isPickingUp, isPickingDown,
            isSwingingToolRight, isSwingingToolLeft, isSwingingToolUp, isSwingingToolDown,
            idleRight, idleLeft, idleUp, idleDown);
    }

    private void FixedUpdate()
    {
        Move();
    }

    private void Move()
    {
        Vector2 movementInput = new Vector2(inputX, inputY) * Time.deltaTime * currentMoveSpeed;

        rigidbody2D.MovePosition(rigidbody2D.position + movementInput);
    }

    private void ResetAnimationTriggers()
    {
        isUsingToolRight = false;
        isUsingToolLeft = false;
        isUsingToolUp = false;
        isUsingToolDown = false;

        isLiftingToolRight = false;
        isLiftingToolLeft = false;
        isLiftingToolUp = false;
        isLiftingToolDown = false;

        isSwingingToolRight = false;
        isSwingingToolLeft = false;
        isSwingingToolUp = false;
        isSwingingToolDown = false;

        isPickingRight = false;
        isPickingLeft = false;
        isPickingUp = false;
        isPickingDown = false;

        toolEffect = ToolEffect.None;
    }

    private void HandleMovementInput()
    {
        inputX = Input.GetAxisRaw("Horizontal");
        inputY = Input.GetAxisRaw("Vertical");

        // Normalize inputs
        if (inputY != 0f && inputX != 0f)
        {
            inputX *= 0.71f;
            inputY *= 0.71f;
        }

        if (inputY != 0f || inputX != 0f)
        {
            isRunning = true;
            isWalking = false;
            isIdle = false;

            DefinePlayerDirection();
        }
        else if (inputY == 0f || inputX == 0f)
        {
            isRunning = false;
            isWalking = false;
            isIdle = true;
        }
    }

    private void HandleWalkInput()
    {
        if (Input.GetKey(KeyCode.LeftShift) || Input.GetKey(KeyCode.RightShift))
        {
            isRunning = true;
            isWalking = false;
            isIdle = false;

            currentMoveSpeed = runningSpeed;
        }
        else
        {
            isRunning = false;
            isWalking = true;
            isIdle = false;

            currentMoveSpeed = walkingSpeed;
        }
    }

    private void DefinePlayerDirection()
    {
        if (inputX < 0f)
        {
            direction = Direction.Left;
        }
        else if (inputX > 0f)
        {
            direction = Direction.Right;
        }
        else if (inputY < 0f)
        {
            direction = Direction.Down;
        }
        else
        {
            direction = Direction.Up;
        }
    }
}