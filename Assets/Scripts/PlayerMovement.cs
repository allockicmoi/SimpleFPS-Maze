using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private CharacterController char_Controller;
    private Vector3 move_Direction;
    public float speed = 5f;
    private float gravity = 10f;
    private float jump_Force = 15f;
    private float vertical_Velocity;

    void Awake()
    {
        char_Controller = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        MovePlayer();
    }

    void MovePlayer()
    {
        move_Direction = new Vector3(Input.GetAxis("Horizontal"), 0f, Input.GetAxis("Vertical"));
        move_Direction = transform.TransformDirection(move_Direction);
        move_Direction *= speed * Time.deltaTime;

        ApplyGravity();

        char_Controller.Move(move_Direction);
    }

    private void ApplyGravity()
    {
        vertical_Velocity -= gravity * Time.deltaTime;

        // jump
        PlayerJump();

        move_Direction.y = vertical_Velocity * Time.deltaTime;
    }

    private void PlayerJump()
    {
        if (char_Controller.isGrounded && Input.GetKeyDown(KeyCode.Space))
        {
            vertical_Velocity = jump_Force;
        }
    }
}
