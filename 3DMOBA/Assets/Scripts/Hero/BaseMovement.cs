using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseMovement : MonoBehaviour
{
    [HideInInspector]
    public Vector3 moveDirection;

    private Rigidbody myBody;

    public float walkSpeed = 5f;
    public float walkForce = 50f;
    public float smoothSpeed = .1f;


    void Awake()
    {
        myBody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        HangleMovement();
    }

    void HangleMovement()
    {

        //Desired velocity to calculate
        Vector3 desiredVelocity = walkSpeed * moveDirection;

        //Velocity calculation between the current and desired.

        Vector3 finalVelocity = desiredVelocity - myBody.velocity;


        if (myBody.useGravity)
        {
            finalVelocity.y = 0;
        }

        myBody.AddForce(desiredVelocity * walkForce, ForceMode.Acceleration);

        // Rotation code line

        Vector3 faceDirection = moveDirection;

        if (faceDirection == Vector3.zero)
        {
            myBody.angularVelocity = Vector3.zero;
        }

        else
        {
            float rotationAngle = AroundAngleAxis(transform.forward,
            faceDirection, Vector3.up);

            myBody.angularVelocity = (Vector3.up * rotationAngle * smoothSpeed);
        }

    }

    float AroundAngleAxis(Vector3 dirA, Vector3 dirB, Vector3 axis)
    {
        float angle = Vector3.Angle(dirA, dirB);

        return angle * (Vector3.Dot(axis, Vector3.Cross(dirA, dirB)) > 0 ? 1 : -1);
    }

}
