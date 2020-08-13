using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationController : MonoBehaviour
{
    float AnimationFirstPitchPosition;
    float AnimationFirstYawPosition;
    float AnimationFirstRollPosition;
    float AnimationLastPitchPosition;
    float AnimationLastYawPosition;
    float AnimationLastRollPosition;

    public GameObject Orientation1;
    public GameObject Orientation2;

    public AnimationClip AnimationGimbalClip;
    public Animator gimbal;

    private void Start()
    {
        gimbal = gameObject.GetComponent<Animator>();
        Debug.Log(gimbal);
    }

    void AnimationStart()
    {
        AnimationFirstPitchPosition = Orientation1.GetComponent<OrientationController>().OrientationPitch;
        AnimationLastPitchPosition = Orientation2.GetComponent<OrientationController>().OrientationPitch;
        AnimationFirstYawPosition = Orientation1.GetComponent<OrientationController>().OrientationYaw;
        AnimationLastYawPosition = Orientation2.GetComponent<OrientationController>().OrientationYaw;
        AnimationFirstRollPosition = Orientation1.GetComponent<OrientationController>().OrientationRoll;
        AnimationLastRollPosition = Orientation2.GetComponent<OrientationController>().OrientationRoll;

        

    }
}
