using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

	public CharacterController2D controller;

	public float runSpeed = 40f;

	float horizontalMove = 0f;
	bool jump = false;
	//bool crouch = false;

	// Update is called once per frame
	void Update()
	{

		horizontalMove = Input.GetAxisRaw("Horizontal") * runSpeed;

		if (Input.GetButtonDown("Jump"))
		{
			Debug.Log("Jumping");
			jump = true;
		}

		

		/*
		if (Input.GetButtonDown("Crouch"))
		{
			crouch = true;
		}
		*/
		/*
		else if (Input.GetButtonUp("Crouch"))
		{
			crouch = false;
		}
		*/


	}

	void LateUpdate()
	{
		// Move our character
		controller.Move(horizontalMove * Time.fixedDeltaTime, jump);
		//jump = false;
		
		if (Input.GetKeyDown("space"))
		{
			Debug.Log("Jumping False");
			jump = false;
		}
		
	}
}