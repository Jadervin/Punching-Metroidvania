using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

	public CharacterController2D controller;
	public Animator animator;

	public float runSpeed = 40f;
	float horizontalMove = 0f;
	bool jump = false;
	public GameObject ground;
	//bool crouch = false;
	//public int jumpCount = 1;
	//public int maxJumps = 1;

	void Start()
    {
		
    }
	// Update is called once per frame
	void Update()
	{

		horizontalMove = Input.GetAxisRaw("Horizontal") * runSpeed;

		animator.SetFloat("speed", Mathf.Abs(horizontalMove));

		if (Input.GetButtonDown("Jump") /*&& jumpCount!=0*/)
		{
			//Debug.Log("Jumping");
			jump = true;
			animator.SetBool("isJumping", true);
			//jumpCount-=1;
		}

		else if(Input.GetButtonDown("Jump") /*&& jumpCount == 0*/)
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

	public void OnLanding()
	{
		Debug.Log("Jumping Anim false");
		animator.SetBool("isJumping", false);
	
    }
	void FixedUpdate()
	{
		controller.Move(horizontalMove * Time.fixedDeltaTime, jump);
		jump = false;
		
		
	}

	
}