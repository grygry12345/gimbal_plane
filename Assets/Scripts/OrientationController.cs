using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OrientationController : MonoBehaviour
{
    public InputField TextboxYaw;
    public InputField TextboxPitch;
    public InputField TextboxRoll;
    public float OrientationYaw;
    public float OrientationPitch;
    public float OrientationRoll;

    private void Awake() // Initialize attributes
    {
        OrientationYaw = 0;
        OrientationPitch = 0;
        OrientationRoll = 0;
        TextboxYaw.text = OrientationYaw.ToString();
        TextboxPitch.text = OrientationPitch.ToString();
        TextboxRoll.text = OrientationRoll.ToString();
    }

    public void OrientationGetCurrent() // Get values from pitch, yaw and roll from sliders.
    {
        OrientationYaw = GimballController.Yaw;
        OrientationPitch = GimballController.Pitch;
        OrientationRoll = GimballController.Roll;

        TextboxYaw.text = OrientationYaw.ToString();
        TextboxPitch.text = OrientationPitch.ToString();
        TextboxRoll.text = OrientationRoll.ToString();
    }

}
