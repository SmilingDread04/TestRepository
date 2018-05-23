using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//Contains Data Types, Classes, & Character Controller Components
public class MoveCharacter : MonoBehaviour
{
    public float speed;
    public float jumpSpeed;
    public float gravity;
    public NewScriptableObject Scripted;
    private CharacterController controller;

    private void Start()
    {
        controller = GetComponent<CharacterController>();
        speed = Scripted.speed;
        jumpSpeed = Scripted.jumpSpeed;
        gravity = Scripted.gravity;
    }

    private Vector3 moveDirection = Vector3.zero;
    void Update()
    {
        if (controller.isGrounded)
        {
            moveDirection.x = Input.GetAxis("Horizontal");
            moveDirection.y = 0;
            moveDirection.z = 0;
            moveDirection = transform.TransformDirection(moveDirection);
            moveDirection *= speed;
            if (Input.GetButton("Jump"))
                moveDirection.y = jumpSpeed;

        }
        moveDirection.y -= gravity * Time.deltaTime;
        controller.Move(moveDirection * Time.deltaTime);
    }
}
