using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lj_PlayerManager : MonoBehaviour
{
    lj_InputManager inputManager;
    lj_PlayerLocomotion playerLocomotion;
    lj_CameraManager cameraManager;
    // Start is called before the first frame update
    private void Awake()
    {
        inputManager = GetComponent<lj_InputManager>();
        playerLocomotion = GetComponent<lj_PlayerLocomotion>();
        cameraManager = FindObjectOfType<lj_CameraManager>();
    }

	private void Update()
	{
        inputManager.HandleAllInputs();
	}
	private void FixedUpdate()
	{
        playerLocomotion.HandleAllMovement();
	}

	private void LateUpdate()
	{
        cameraManager.FollowTarget();
	}
}
