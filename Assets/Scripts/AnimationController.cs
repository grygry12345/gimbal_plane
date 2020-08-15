using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationController : MonoBehaviour
{
    public GameObject Orientation1;
    public GameObject Orientation2;

    float FirstPitchPosition;
    float FirstYawPosition;
    float FirstRollPosition;
    float LastPitchPosition;
    float LastYawPosition;
    float LastRollPosition;

    float SpeedPitch;
    float SpeedYaw;
    float SpeedRoll;

    public float AnimationTime;

    bool isAnimationButtonClicked;

    private void Start()  // Initialize attributes
    {
        isAnimationButtonClicked = false;
        FirstPitchPosition = 0;
        FirstYawPosition = 0;
        FirstRollPosition = 0;
        LastPitchPosition = 0;
        LastYawPosition = 0;
        LastRollPosition = 0;
    }

    private void Update()
    {
        if (isAnimationButtonClicked == true
            && Mathf.Abs(GimballController.TransformPitch.eulerAngles.x - LastPitchPosition) >= 0.01
            && Mathf.Abs(GimballController.TransformYaw.eulerAngles.y - LastYawPosition) >= 0.01
            && Mathf.Abs(GimballController.TransformRoll.eulerAngles.z - LastRollPosition) >= 0.01)
        {
            GimballController.TransformPitch.Rotate(new Vector3(SpeedPitch, 0, 0) * Time.deltaTime);
            GimballController.TransformYaw.Rotate(new Vector3(0, SpeedYaw, 0) * Time.deltaTime);
            GimballController.TransformRoll.Rotate(new Vector3(0, 0, SpeedRoll) * Time.deltaTime);
        }
    }

    public void AnimationActivateClick()
    {
        FirstPitchPosition = Orientation1.GetComponent<OrientationController>().OrientationPitch;
        FirstYawPosition = Orientation1.GetComponent<OrientationController>().OrientationYaw;
        FirstRollPosition = Orientation1.GetComponent<OrientationController>().OrientationRoll;
        LastPitchPosition = Orientation2.GetComponent<OrientationController>().OrientationPitch;
        LastYawPosition = Orientation2.GetComponent<OrientationController>().OrientationYaw;
        LastRollPosition = Orientation2.GetComponent<OrientationController>().OrientationRoll;

        SpeedPitch = (LastPitchPosition - FirstPitchPosition) / AnimationTime;
        SpeedRoll = (LastRollPosition - FirstRollPosition) / AnimationTime;
        SpeedYaw = (LastYawPosition - FirstYawPosition) / AnimationTime;

        GimballController.TransformPitch.eulerAngles = new Vector3(FirstPitchPosition, 0, 0);
        GimballController.TransformYaw.eulerAngles = new Vector3(0, FirstYawPosition, 0);
        GimballController.TransformPitch.eulerAngles = new Vector3(0, 0, FirstRollPosition);

        isAnimationButtonClicked = true;
    }
}
