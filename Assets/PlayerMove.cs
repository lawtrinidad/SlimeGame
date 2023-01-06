using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour {

	public CharacterController2D controller;
	public Animator animator;

	float horizontalMove = 0f;
	public float runSpeed = 50f;
	bool jump = false;

	void Update () {
		
		horizontalMove = Input.GetAxisRaw("Horizontal") * runSpeed;
		animator.SetFloat("Speed", Math.Abs(horizontalMove));

		if (Input.GetButtonDown("Jump"))
		{
			jump = true;
			animator.SetBool("IsJumping", true);
		}

	}
	
	public void OnLanding ()
	{
		animator.SetBool("IsJumping", false);
	}

	void FixedUpdate () {
		
		controller.Move(horizontalMove*Time.fixedDeltaTime, false, jump);

		jump = false;

	}
}
