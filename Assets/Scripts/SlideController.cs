using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

public class SlideController : MonoBehaviour
{
    private Slider Slide;
    private InputField TextBox;
    private Text Info;

    private void Start()
    {
        Slide = gameObject.GetComponentInChildren<Slider>();
        TextBox = gameObject.GetComponentInChildren<InputField>();
        Info = gameObject.GetComponentInChildren<Text>();
        
        Slide.value = 0;
        TextBox.text = Slide.value.ToString();

    }

    public void OnSliderUpdate() // Update value TextBox when Slider is changed then update the gimbal
    {
        TextBox.text = Slide.value.ToString();

        switch (Info.text)
        {
            case "Pitch":
                GimballController.TransformPitch.eulerAngles = new Vector3(Slide.value, 0, 0);
                GimballController.Pitch = Slide.value;
                break;
            case "Yaw":
                GimballController.TransformYaw.eulerAngles = new Vector3(0,Slide.value,0);
                GimballController.Yaw = Slide.value;
                break;
            case "Roll":
                GimballController.TransformRoll.eulerAngles = new Vector3(0, 0, Slide.value);
                GimballController.Roll = Slide.value;
                break;
            default:
                Debug.LogError("Error in getting angles.");
                break;
        }
    }

    public void OnTextBoxUpdate() // Update value Slider when Textbox is updated then update the gimbal
    {
        Slide.value = float.Parse(TextBox.GetComponentInChildren<Text>().text);

        switch (Info.text)
        {
            case "Pitch":
                GimballController.TransformPitch.eulerAngles = new Vector3(Slide.value, 0, 0);
                GimballController.Pitch = Slide.value;
                break;
            case "Yaw":
                GimballController.TransformYaw.eulerAngles = new Vector3(0, Slide.value, 0);
                GimballController.Yaw = Slide.value;
                break;
            case "Roll":
                GimballController.TransformRoll.eulerAngles = new Vector3(0, 0, Slide.value);
                GimballController.Roll = Slide.value;
                break;
            default:
                Debug.LogError("Error in getting angles.");
                break;
        }
    }
}
