using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    Rigidbody myRigidbody;
    Animator animator;
    [SerializeField] float runSpeed = 5f;
    private readonly float horizontalSpeed = 10f;
    public float jumpStrength = 20f;

    private float setOffset = 0;
    private bool rightPressed = false;
    private bool leftPressed = false;


    private void Start()
    {
        myRigidbody = GetComponent<Rigidbody>();
        animator = GetComponent<Animator>();
    }

    private void FixedUpdate()
    {
        RunForward();
    }

    private void Update()
    {
        MoveLeftandRight();
        Jump();
        Slide();
    }

    private void RunForward()
    {
        Vector3 forwardMove = runSpeed * Time.fixedDeltaTime * transform.forward;
        myRigidbody.MovePosition(myRigidbody.position + forwardMove);
    }

    private void Slide()
    {
        if (Input.GetKeyDown(KeyCode.S))
        {
            animator.SetTrigger("Slide");
            Vector3 stop = new Vector3(0, myRigidbody.velocity.y, myRigidbody.velocity.z);
            myRigidbody.velocity = transform.TransformDirection(stop);
        }
    }

    private void Jump()
    {
        float yPosition = transform.position.y;

        if (Input.GetKeyDown(KeyCode.Space))
        {
            Vector3 jumpVelocity = new Vector3(myRigidbody.velocity.x, jumpStrength, myRigidbody.velocity.z);
            myRigidbody.velocity = transform.TransformDirection(jumpVelocity);
        }
        if (yPosition >= 0.1)
        {
            animator.SetBool("isJump", true);
        }
        else if (yPosition < 0.1)
        {
            animator.SetBool("isJump", false);
        }
    }

    private void MoveLeftandRight()
    {
        float currentOffset = transform.position.x;

        if (Input.GetKeyDown(KeyCode.A) && setOffset == 0)
        {
            setOffset = -2;
            animator.SetBool("isLeft", true);
            leftPressed = true;
        }
        else if (Input.GetKeyDown(KeyCode.A) && setOffset == 2)
        {
            setOffset = 0;
            animator.SetBool("isLeft", true);
            leftPressed = true;
        }
        else if (Input.GetKeyDown(KeyCode.D) && setOffset == 0)
        {
            setOffset = 2;
            animator.SetBool("isRight", true);
            rightPressed = true;
        }
        else if (Input.GetKeyDown(KeyCode.D) && setOffset == -2)
        {
            setOffset = 0;
            animator.SetBool("isRight", true);
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
            animator.SetBool("isRight", false);
            Vector3 playerVelocity = new Vector3(0, myRigidbody.velocity.y, myRigidbody.velocity.z);
            myRigidbody.velocity = transform.TransformDirection(playerVelocity);
        }
        if (currentOffset < setOffset && leftPressed)
        {
            animator.SetBool("isLeft", false);
            leftPressed = false;
            Vector3 playerVelocity = new Vector3(0, myRigidbody.velocity.y, myRigidbody.velocity.z);
            myRigidbody.velocity = transform.TransformDirection(playerVelocity);
        }
    }
}
