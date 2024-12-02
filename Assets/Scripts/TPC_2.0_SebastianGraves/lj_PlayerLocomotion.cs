using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lj_PlayerLocomotion : MonoBehaviour
{
	lj_inputManager inputManager;
	Vector3 moveDirection;
	Transform cameraObject;
	Rigidbody playerRigidbody;

	public float movementSpeed = 7;
	public float rotationSpeed = 15;
	private void Awake()
	{
		inputManager = GetComponent<lj_inputManager>();
		playerRigidbody = GetComponent<Rigidbody>();
		cameraObject = Camera.main.transform;

	}
	private void HandleMovement()
	{
		moveDirection = cameraObject.forward * inputManager.verticalInput;//Movement input
		moveDirection = moveDirection + cameraObject.right * inputManager.horizontalInput;
		moveDirection.Normalize();
		moveDirection.y = 0;
		moveDirection = moveDirection * movementSpeed;

		Vector3 movementVelocity = moveDirection;
		playerRigidbody.velocity = movementVelocity;

	}

	private void HandleRotation()
	{
		Vector3 targetDirection = Vector3.zero;
		targetDirection = cameraObject.forward * inputManager.verticalInput;
		targetDirection = targetDirection + cameraObject.right * inputManager.horizontalInput;
		targetDirection.Normalize();
		targetDirection.y = 0; //set this to equal ground angle on a horseback

		if (targetDirection == Vector3.zero)
		{
			targetDirection = transform.forward;
		}

		Quaternion targetRotation = Quaternion.LookRotation(targetDirection);
		Quaternion playerRotation = Quaternion.Slerp(transform.rotation, targetRotation, rotationSpeed * Time.deltaTime);

		transform.rotation = playerRotation;
	}

	public void HandleAllMovement()
	{
		HandleMovement();
		HandleRotation();
	}
}
