using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[ExecuteInEditMode]
public class LimitFrames : MonoBehaviour
{
    //test
    [SerializeField]
    private int frameRateCap;
    // Update is called once per frame
    void Update()
    {
        Application.targetFrameRate = frameRateCap;
    }
}
