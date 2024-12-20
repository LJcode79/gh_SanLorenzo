using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lj_CameraManager : MonoBehaviour
{
    public Transform targetTransform; //object the camera will follow
    public Vector3 cameraFollowVelocity = Vector3.zero;
    public float cameraFollowSpeed = 0.2f;
    public float lookAngle; //look up and down
    public float pivotAngle; //look left and right
	public void Awake()
	{
        targetTransform = FindObjectOfType<lj_PlayerManager>().transform;
	    
    }
	public void FollowTarget()
    {
        Vector3 targetPosition = Vector3.SmoothDamp(transform.position, targetTransform.position, ref cameraFollowVelocity, cameraFollowSpeed);
        transform.position = targetPosition;
    }

    public void RotateCamera()
    {

    }
}
