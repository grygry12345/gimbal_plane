using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GimballController : MonoBehaviour
{
    public static Transform PitchTransform; // X axis
    public static Transform YawTransform; // Y axis
    public static Transform RollTransform; // Z axis
    public static float Roll;
    public static float Pitch;
    public static float Yaw;

    private void Awake() // Initialize axises and inintialize transforms
    {
        PitchTransform = transform.Find("Pitch");
        YawTransform = PitchTransform.Find("Yaw");
        RollTransform = YawTransform.Find("Roll");
        Roll = 0;
        Pitch = 0;
        Yaw = 0;
    }
}
