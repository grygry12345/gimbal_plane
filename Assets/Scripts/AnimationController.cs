using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationController : MonoBehaviour
{
    public GameObject Orientation1;
    public GameObject Orientation2;

    Vector3 ReverseTurnPitch;
    Vector3 ReverseTurnYaw;
    Vector3 ReverseTurnRoll;
    Vector3 TurnPitch;
    Vector3 TurnYaw;
    Vector3 TurnRoll;

    float FirstPitchDegree;
    float FirstYawDegree;
    float FirstRollDegree;
    float LastPitchDegree;
    float LastYawDegree;
    float LastRollDegree;

    float DiffAnglePitch;
    float DiffAngleYaw;
    float DiffAngleRoll;

    public float AnimationTime;

    bool isAnimationButtonClicked;
    bool stoppedPitch;
    bool stoppedYaw;
    bool stoppedRoll;

    private void Start()  // Initialize attributes
    {
        isAnimationButtonClicked = false;
        stoppedPitch = true;
        stoppedYaw = true;
        stoppedRoll = true;
        FirstPitchDegree = 0;
        FirstYawDegree = 0;
        FirstRollDegree = 0;
        LastPitchDegree = 0;
        LastYawDegree = 0;
        LastRollDegree = 0;

        TurnPitch = new Vector3(1f, 0f, 0f);
        TurnYaw = new Vector3(0f, 1f, 0f);
        TurnRoll = new Vector3(0f, 0f, 1f);
        ReverseTurnPitch = new Vector3(-1f, 0f, 0f);
        ReverseTurnYaw = new Vector3(0f, -1f, 0f);
        ReverseTurnRoll = new Vector3(0f, 0f, -1f);
    }

    private void Update()
    {
        if (isAnimationButtonClicked)
        {
            if (DiffAnglePitch >= 0 && DiffAngleYaw >= 0 && DiffAngleRoll >= 0) // 111
            {
                if (Mathf.Round(GimballController.TransformPitch.eulerAngles.x - LastPitchDegree) != 0 && !stoppedPitch)
                {
                    GimballController.TransformPitch.eulerAngles += TurnPitch * Time.deltaTime * AnimationTime;
                }
                else
                {
                    stoppedPitch = true;
                }
                if (Mathf.Round(GimballController.TransformYaw.eulerAngles.y - LastYawDegree) != 0 && !stoppedYaw)
                {
                    GimballController.TransformYaw.eulerAngles += TurnYaw * Time.deltaTime * AnimationTime;
                }
                else
                {
                    stoppedYaw = true;
                }
                if (Mathf.Round(GimballController.TransformRoll.eulerAngles.z - LastRollDegree) != 0 && !stoppedRoll)
                {
                    GimballController.TransformRoll.eulerAngles += TurnRoll * Time.deltaTime * AnimationTime;
                }
                else
                {
                    stoppedRoll = true;
                }
            }
            else if (DiffAnglePitch >= 0 && DiffAngleYaw >= 0 && DiffAngleRoll < 0) // 110
            {
                if (Mathf.Round(GimballController.TransformPitch.eulerAngles.x - LastPitchDegree) != 0 && !stoppedPitch)
                {
                    GimballController.TransformPitch.eulerAngles += TurnPitch * Time.deltaTime * AnimationTime;
                }
                else
                {
                    stoppedPitch = true;
                }
                if (Mathf.Round(GimballController.TransformYaw.eulerAngles.y - LastYawDegree) != 0 && !stoppedYaw)
                {
                    GimballController.TransformYaw.eulerAngles += TurnYaw * Time.deltaTime * AnimationTime;
                }
                else
                {
                    stoppedYaw = true;
                }
                if (Mathf.Round(GimballController.TransformRoll.eulerAngles.z - LastRollDegree) != 0 && !stoppedRoll)
                {
                    GimballController.TransformRoll.eulerAngles += ReverseTurnRoll * Time.deltaTime * AnimationTime;
                }
                else
                {
                    stoppedRoll = true;
                }
            }
            else if (DiffAnglePitch >= 0 && DiffAngleYaw < 0 && DiffAngleRoll >= 0) // 101
            {
                if (Mathf.Round(GimballController.TransformPitch.eulerAngles.x - LastPitchDegree) != 0 && !stoppedPitch)
                {
                    GimballController.TransformPitch.eulerAngles += TurnPitch * Time.deltaTime * AnimationTime;
                }
                else
                {
                    stoppedPitch = true;
                }
                if (Mathf.Round(GimballController.TransformYaw.eulerAngles.y - LastYawDegree) != 0 && !stoppedYaw)
                {
                    GimballController.TransformYaw.eulerAngles += ReverseTurnYaw * Time.deltaTime * AnimationTime;
                }
                else
                {
                    stoppedYaw = true;
                }
                if (Mathf.Round(GimballController.TransformRoll.eulerAngles.z - LastRollDegree) != 0 && !stoppedRoll)
                {
                    GimballController.TransformRoll.eulerAngles += TurnRoll * Time.deltaTime * AnimationTime;
                }
                else
                {
                    stoppedRoll = true;
                }
            }
            else if (DiffAnglePitch >= 0 && DiffAngleYaw < 0 && DiffAngleRoll < 0) // 100
            {
                if (Mathf.Round(GimballController.TransformPitch.eulerAngles.x - LastPitchDegree) != 0 && !stoppedPitch)
                {
                    GimballController.TransformPitch.eulerAngles += TurnPitch * Time.deltaTime * AnimationTime;
                }
                else
                {
                    stoppedPitch = true;
                }
                if (Mathf.Round(GimballController.TransformYaw.eulerAngles.y - LastYawDegree) != 0 && !stoppedYaw)
                {
                    GimballController.TransformYaw.eulerAngles += ReverseTurnYaw * Time.deltaTime * AnimationTime;
                }
                else
                {
                    stoppedYaw = true;
                }
                if (Mathf.Round(GimballController.TransformRoll.eulerAngles.z - LastRollDegree) != 0 && !stoppedRoll)
                {
                    GimballController.TransformRoll.eulerAngles += ReverseTurnRoll * Time.deltaTime * AnimationTime;
                }
                else
                {
                    stoppedRoll = true;
                }
            }
            else if (DiffAnglePitch < 0 && DiffAngleYaw >= 0 && DiffAngleRoll >= 0) // 011
            {
                if (Mathf.Round(GimballController.TransformPitch.eulerAngles.x - LastPitchDegree) != 0 && !stoppedPitch)
                {
                    GimballController.TransformPitch.eulerAngles += ReverseTurnPitch * Time.deltaTime * AnimationTime;
                }
                else
                {
                    stoppedPitch = true;
                }
                if (Mathf.Round(GimballController.TransformYaw.eulerAngles.y - LastYawDegree) != 0 && !stoppedYaw)
                {
                    GimballController.TransformYaw.eulerAngles += TurnYaw * Time.deltaTime * AnimationTime;
                }
                else
                {
                    stoppedYaw = true;
                }
                if (Mathf.Round(GimballController.TransformRoll.eulerAngles.z - LastRollDegree) != 0 && !stoppedRoll)
                {
                    GimballController.TransformRoll.eulerAngles += TurnRoll * Time.deltaTime * AnimationTime;
                }
                else
                {
                    stoppedRoll = true;
                }
            }
            else if (DiffAnglePitch < 0 && DiffAngleYaw >= 0 && DiffAngleRoll < 0) // 010
            {
                if (Mathf.Round(GimballController.TransformPitch.eulerAngles.x - LastPitchDegree) != 0 && !stoppedPitch)
                {
                    GimballController.TransformPitch.eulerAngles += ReverseTurnPitch * Time.deltaTime * AnimationTime;
                }
                else
                {
                    stoppedPitch = true;
                }
                if (Mathf.Round(GimballController.TransformYaw.eulerAngles.y - LastYawDegree) != 0 && !stoppedYaw)
                {
                    GimballController.TransformYaw.eulerAngles += TurnYaw * Time.deltaTime * AnimationTime;
                }
                else
                {
                    stoppedYaw = true;
                }
                if (Mathf.Round(GimballController.TransformRoll.eulerAngles.z - LastRollDegree) != 0 && !stoppedRoll)
                {
                    GimballController.TransformRoll.eulerAngles += ReverseTurnRoll * Time.deltaTime * AnimationTime;
                }
                else
                {
                    stoppedRoll = true;
                }
            }
            else if (DiffAnglePitch < 0 && DiffAngleYaw < 0 && DiffAngleRoll >= 0) // 001
            {
                if (Mathf.Round(GimballController.TransformPitch.eulerAngles.x - LastPitchDegree) != 0 && !stoppedPitch)
                {
                    GimballController.TransformPitch.eulerAngles += ReverseTurnPitch * Time.deltaTime * AnimationTime;
                }
                else
                {
                    stoppedPitch = true;
                }
                if (Mathf.Round(GimballController.TransformYaw.eulerAngles.y - LastYawDegree) != 0 && !stoppedYaw)
                {
                    GimballController.TransformYaw.eulerAngles += ReverseTurnYaw * Time.deltaTime * AnimationTime;
                }
                else
                {
                    stoppedYaw = true;
                }
                if (Mathf.Round(GimballController.TransformRoll.eulerAngles.z - LastRollDegree) != 0 && !stoppedRoll)
                {
                    GimballController.TransformRoll.eulerAngles += TurnRoll * Time.deltaTime * AnimationTime;
                }
                else
                {
                    stoppedRoll = true;
                }
            }
            else if (DiffAnglePitch < 0 && DiffAngleYaw < 0 && DiffAngleRoll < 0) // 000
            {
                if (Mathf.Round(GimballController.TransformPitch.eulerAngles.x - LastPitchDegree) != 0 && !stoppedPitch)
                {
                    GimballController.TransformPitch.eulerAngles += ReverseTurnPitch * Time.deltaTime * AnimationTime;
                }
                else
                {
                    stoppedPitch = true;
                }
                if (Mathf.Round(GimballController.TransformYaw.eulerAngles.y - LastYawDegree) != 0 && !stoppedYaw)
                {
                    GimballController.TransformYaw.eulerAngles += ReverseTurnYaw * Time.deltaTime * AnimationTime;
                }
                else
                {
                    stoppedYaw = true;
                }
                if (Mathf.Round(GimballController.TransformRoll.eulerAngles.z - LastRollDegree) != 0 && !stoppedRoll)
                {
                    GimballController.TransformRoll.eulerAngles += ReverseTurnRoll * Time.deltaTime * AnimationTime;
                }
                else
                {
                    stoppedRoll = true;
                }
            }
        }
        if (stoppedPitch && stoppedYaw && stoppedRoll)
        {
            isAnimationButtonClicked = false;
        }
    }

    public void AnimationActivateClick()
    {
        FirstPitchDegree = Orientation1.GetComponent<OrientationController>().OrientationPitch;
        FirstYawDegree = Orientation1.GetComponent<OrientationController>().OrientationYaw;
        FirstRollDegree = Orientation1.GetComponent<OrientationController>().OrientationRoll;

        LastPitchDegree = Orientation2.GetComponent<OrientationController>().OrientationPitch;
        LastYawDegree = Orientation2.GetComponent<OrientationController>().OrientationYaw;
        LastRollDegree = Orientation2.GetComponent<OrientationController>().OrientationRoll;

        DiffAnglePitch = LastPitchDegree - FirstPitchDegree;
        DiffAngleYaw = LastYawDegree - FirstYawDegree;
        DiffAngleRoll = LastRollDegree - FirstRollDegree;

        GimballController.TransformPitch.eulerAngles = new Vector3(FirstPitchDegree, 0, 0);
        GimballController.TransformYaw.eulerAngles = new Vector3(0, FirstYawDegree, 0);
        GimballController.TransformRoll.eulerAngles = new Vector3(0, 0, FirstRollDegree);

        stoppedPitch = false;
        stoppedYaw = false;
        stoppedRoll = false;
        isAnimationButtonClicked = true;
    }
}
