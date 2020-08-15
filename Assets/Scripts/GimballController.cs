using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GimballController : MonoBehaviour
{
    public static Transform TransformPitch; // X axis
    public static Transform TransformYaw; // Y axis
    public static Transform TransformRoll; // Z axis
    public static float Pitch;
    public static float Yaw;
    public static float Roll;


    private void Awake() // Initialize axises and inintialize transforms
    {
        TransformPitch = transform.Find("Pitch");
        TransformYaw = TransformPitch.Find("Yaw");
        TransformRoll = TransformYaw.Find("Roll");
    }
}
