using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lj_PlayerManager : MonoBehaviour
{
    lj_inputManager inputManager;
    lj_PlayerLocomotion playerLocomotion;
    // Start is called before the first frame update
    private void Awake()
    {
        inputManager = GetComponent<lj_inputManager>();
        playerLocomotion = GetComponent<lj_PlayerLocomotion>();    }

	private void Update()
	{
        inputManager.HandleAllInputs();
	}
	private void FixedUpdate()
	{
        playerLocomotion.HandleAllMovement();
	}

}
