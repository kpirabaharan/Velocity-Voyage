using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] float runSpeed = 5f;
    private readonly float horizontalSpeed = 10f;

    private float setOffset = 0;
    private bool rightPressed = false;
    private bool leftPressed = false;

    Rigidbody myRigidbody;

    private void Start()
    {
        myRigidbody = GetComponent<Rigidbody>();
    }

    private void FixedUpdate()
    {
        RunForward();
    }

    private void Update()
    {
        MoveLeftandRight();
    }

    private void RunForward()
    {
        Vector3 forwardMove = runSpeed * Time.fixedDeltaTime * transform.forward;
        myRigidbody.MovePosition(myRigidbody.position + forwardMove);
    }

    private void MoveLeftandRight()
    {
        float currentOffset = transform.position.x;

        if (Input.GetKeyDown(KeyCode.A) && setOffset == 0)
        {
            setOffset = -2;
            leftPressed = true;
        }
        else if (Input.GetKeyDown(KeyCode.A) && setOffset == 2)
        {
            setOffset = 0;
            leftPressed = true;
        }
        else if (Input.GetKeyDown(KeyCode.D) && setOffset == 0)
        {
            setOffset = 2;
            rightPressed = true;
        }
        else if (Input.GetKeyDown(KeyCode.D) && setOffset == -2)
        {
            setOffset = 0;
            rightPressed = true;
        }

        if (currentOffset < setOffset && rightPressed)
        {
            Vector3 playerVelocity = new Vector3(horizontalSpeed, myRigidbody.velocity.y, myRigidbody.velocity.z);
            myRigidbody.velocity = transform.TransformDirection(playerVelocity);
        }
        if (currentOffset > setOffset && leftPressed)
        {
            Vector3 playerVelocity = new Vector3(-horizontalSpeed, myRigidbody.velocity.y, myRigidbody.velocity.z);
            myRigidbody.velocity = transform.TransformDirection(playerVelocity);
        }
        if(currentOffset > setOffset && rightPressed)
        {
            rightPressed = false;
            Vector3 playerVelocity = new Vector3(0, myRigidbody.velocity.y, myRigidbody.velocity.z);
            myRigidbody.velocity = transform.TransformDirection(playerVelocity);
        }
        if (currentOffset < setOffset && leftPressed)
        {
            leftPressed = false;
            Vector3 playerVelocity = new Vector3(0, myRigidbody.velocity.y, myRigidbody.velocity.z);
            myRigidbody.velocity = transform.TransformDirection(playerVelocity);
        }
    }
}
