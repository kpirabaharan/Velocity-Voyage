using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] float runSpeed = 5f;
    //private float xOffset = 0f;

    Vector2 moveInput;
    Rigidbody myRigidbody;

    private void Start()
    {
        myRigidbody = GetComponent<Rigidbody>();
    }

    private void FixedUpdate()
    {
        Vector3 forwardMove = transform.forward * runSpeed * Time.fixedDeltaTime;
        myRigidbody.MovePosition(myRigidbody.position + forwardMove);
    }

    // Update is called once per frame
    private void Update()
    {
        Run();
    }

    private void Run()
    {
        Vector3 playerVelocity = new Vector3(moveInput.x * runSpeed, myRigidbody.velocity.y, myRigidbody.velocity.z);
        myRigidbody.velocity = transform.TransformDirection(playerVelocity);
    }


    public void OnMove(InputValue value)
    {
        moveInput = value.Get<Vector2>();
        Debug.Log("Move:");
    }
}
