using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMoveKeyboard : MonoBehaviour
{

    private characterAnimation playerAnimation;

    private BaseMovement baseMovement;
    private Quaternion spaceScreenMovement;
    private Vector3 screenMoveForward;
    private Vector3 screenMoveRight;

    // Start is called before the first frame update
    void Awake()
    {
        baseMovement = GetComponent<BaseMovement>();
        baseMovement.moveDirection = Vector3.zero;

        playerAnimation = GetComponent<characterAnimation>();
    }

    void Start()
    {
        SetScreenMovement();
    }
    void Update()
    {
        MovementInput();
    }

    void MovementInput()
    {
        baseMovement.moveDirection = Input.GetAxis(AxisManager.HORIZONTAL_AXIS)
        * screenMoveRight + Input.GetAxis(AxisManager.VERTICAL_AXIS) * screenMoveForward;

        // animate

        if(Input.GetAxis(AxisManager.HORIZONTAL_AXIS) !=0
        || Input.GetAxis(AxisManager.VERTICAL_AXIS) !=0)
        {
            playerAnimation.Walk(true);
        } 
        
        else
        {
            playerAnimation.Walk(false);
        }

        if(baseMovement.moveDirection.sqrMagnitude > 1)
        {
            baseMovement.moveDirection.Normalize();
        }
    }

    void SetScreenMovement()
    {
        spaceScreenMovement = Quaternion.Euler(0f, Camera.main.transform.eulerAngles.y,0f);
        screenMoveForward = spaceScreenMovement * Vector3.forward;
        screenMoveRight = spaceScreenMovement * Vector3.right;
    }


}
