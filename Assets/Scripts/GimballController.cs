using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GimballController : MonoBehaviour
{
    public static Transform TransformPitch; // X axis
    public static Transform TransformYaw; // Y axis
    public static Transform TransformRoll; // Z axis
    public static float GimballYaw;
    public static float GimballPitch;
    public static float GimballRoll;

    private void Awake() // Initialize axises and inintialize transforms
    {
        TransformPitch = transform.Find("Pitch");
        TransformYaw = TransformPitch.Find("Yaw");
        TransformRoll = TransformYaw.Find("Roll");
        GimballYaw = 0;
        GimballPitch = 0;
        GimballYaw = 0;
    }
}
