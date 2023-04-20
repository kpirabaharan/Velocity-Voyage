using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] float runSpeed = 5f;
    private readonly float horizontalSpeed = 10f;

    private float setOffset = 0;

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
        }
        else if (Input.GetKeyDown(KeyCode.A) && setOffset == 2)
        {
            setOffset = 0;
        }
        else if (Input.GetKeyDown(KeyCode.D) && setOffset == 0)
        {
            setOffset = 2;
        }
        else if (Input.GetKeyDown(KeyCode.D) && setOffset == -2)
        {
            setOffset = 0;
        }

        if (currentOffset < setOffset)
        {
            Vector3 playerVelocity = new Vector3(horizontalSpeed, myRigidbody.velocity.y, myRigidbody.velocity.z);
            myRigidbody.velocity = transform.TransformDirection(playerVelocity);
            //Vector3 rightMove = horizontalSpeed * Time.fixedDeltaTime * transform.right;
            //myRigidbody.MovePosition(myRigidbody.position + rightMove);
        }
        if (currentOffset > setOffset+0.2)
        {
            Vector3 playerVelocity = new Vector3(-horizontalSpeed, myRigidbody.velocity.y, myRigidbody.velocity.z);
            myRigidbody.velocity = transform.TransformDirection(playerVelocity);
            //Vector3 leftMove = -horizontalSpeed * Time.fixedDeltaTime * transform.right;
            //myRigidbody.MovePosition(myRigidbody.position + leftMove);
        }
    }
}
