using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player_movement : MonoBehaviour
{
    public CharacterController2D controller;

    float move_horizontal=0f;
    public float movement_speed = 50f;

    public Animator animator;

    bool jump = false;

    private void Update()
    {
        move_horizontal = Input.GetAxisRaw("Horizontal")*movement_speed;
        animator.SetFloat("speed", Mathf.Abs(move_horizontal));

        if (Input.GetKeyDown(KeyCode.UpArrow) || Input.GetKeyDown(KeyCode.W))
        {
            jump = true;
            animator.SetBool("isJumping", true);
        }
    }

    private void FixedUpdate()
    {
        controller.Move(move_horizontal*Time.fixedDeltaTime, false, jump);
        jump = false;
    }

    public void OnGround()
    {
        animator.SetBool("isJumping", false);
    }
}
