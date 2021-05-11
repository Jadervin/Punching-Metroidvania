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
	public int jumpCount = 1;
	public int maxJumps = 1;

	// Update is called once per frame
	void Update()
	{

		horizontalMove = Input.GetAxisRaw("Horizontal") * runSpeed;

		if (Input.GetButtonDown("Jump") && jumpCount!=0)
		{
			Debug.Log("Jumping");
			jump = true;
			//jumpCount-=1;
		}
		else if(Input.GetButtonDown("Jump") && jumpCount == 0)
        {
			jump = false;
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

	void FixedUpdate()
	{
		controller.Move(horizontalMove * Time.fixedDeltaTime, jump);
		jump = false;
		
		
	}

	
}